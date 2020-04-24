using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework_10
{

    class Crawler
    {
        public event Action<Crawler> CrawlerStopped;
        public event Action<Crawler, string, string> PageDownloaded;

        //所有已下载和待下载URL，key是URL，value表示是否下载成功
        private Dictionary<string, bool> urls = new Dictionary<string, bool>();

        //待下载队列
        private Queue<string> pending = new Queue<string>();

        //URL检测表达式，用于在HTML文本中查找URL
        private readonly string urlDetectRegex = @"(href|HREF)\s*=\s*[""'](?<url>[^""'#>]+)[""']";

        //URL解析表达式
        public static readonly string urlParseRegex = @"^(?<site>https?://(?<host>[\w\d.]+)(:\d+)?($|/))([\w\d]+/)*(?<file>[^#?]*)";
        public string HostFilter { get; set; } //主机过滤规则
        public string FileFilter { get; set; } //文件过滤规则
        public int MaxPage { get; set; } //最大下载数量
        public string StartURL { get; set; } //起始网址
        public Encoding HtmlEncoding { get; set; } //网页编码
        public Dictionary<string, bool> DownloadedPages { get => urls; }
        public List<Task> downLoadParseTasks = new List<Task>();
        private int finishedTaskCount = 0;
        public int ParallelCount { get; set; } = 0;

        public Crawler()
        {
            MaxPage = 100;
            HtmlEncoding = Encoding.UTF8;
        }

        public void Start()
        {
            urls.Clear();
            pending.Clear();
            pending.Enqueue(StartURL);
            int count = 0;

            while (count < MaxPage && pending.Count > 0)
            {
                string url = pending.Dequeue();
                try
                {
                    string html = DownLoad(url);
                    urls[url] = true;
                    PageDownloaded(this, url, "success");
                    Parse(html, url);//解析,并加入新的链接
                }
                catch (Exception ex)
                {
                    PageDownloaded(this, url, "  Error:" + ex.Message);
                }
                count++;
            }
            CrawlerStopped(this);
        }

        public void ParallelStart()
        {
            urls.Clear();
            pending.Clear();
            pending.Enqueue(StartURL);
            downLoadParseTasks.Clear();
            finishedTaskCount = 0;
            ParallelCount = 0;
            while (ParallelCount < MaxPage &&
                ((pending.Count > 0) || (downLoadParseTasks.Count > finishedTaskCount))) 
            {
                if(pending.Count > 0)
                {
                    lock (this.pending)
                    {
                        string url = pending.Dequeue();
                        try
                        {
                            //下载,解析,并加入新的链接
                            Task downLoadParseTask = Task.Run(() => ParallelParse(url));
                            lock (this.downLoadParseTasks)
                            {
                                downLoadParseTasks.Add(downLoadParseTask);
                            }
                        }
                        catch (Exception ex)
                        {
                            PageDownloaded(this, url, "  Error:" + ex.Message);
                        }
                    }
                    
                }
                
            }
            CrawlerStopped(this);
        }



        private string DownLoad(string url)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString(url);
            string fileName = urls.Count.ToString();
            File.WriteAllText(fileName, html, Encoding.UTF8);
            return html;
        }

        private void Parse(string html, string pageUrl)
        {

            var matches = new Regex(urlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "") continue;
                linkUrl = FixUrl(linkUrl, pageUrl);//转绝对路径

                //解析出host和file两个部分，进行过滤
                Match linkUrlMatch = Regex.Match(linkUrl, urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (file == "") file = "index.html";

                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                    && !urls.ContainsKey(linkUrl))
                {
                    pending.Enqueue(linkUrl);
                    urls.Add(linkUrl, false); 
                }
            }
        }

        private void ParallelParse(string pageUrl)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString(pageUrl);
            string fileName = urls.Count.ToString();
            StreamWriter writer = null;
            try
            {
                FileStream stream = new FileStream(fileName,
                    FileMode.Create, FileAccess.ReadWrite);
                writer = new StreamWriter(stream, Encoding.UTF8);
                writer.Write(html);
            }
            catch { }
            finally
            {
                if (writer != null) writer.Close();
            }
            
            var matches = new Regex(urlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "") continue;
                linkUrl = FixUrl(linkUrl, pageUrl);//转绝对路径

                //解析出host和file两个部分，进行过滤
                Match linkUrlMatch = Regex.Match(linkUrl, urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (file == "") file = "index.html";

                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                    && !urls.ContainsKey(linkUrl))
                {
                    lock (this.pending)
                    {
                        pending.Enqueue(linkUrl);
                        urls.Add(linkUrl, false);
                        lock (this)
                        {
                            ParallelCount++;
                        }
                    }
                }
            }
            urls[pageUrl] = true;
            lock (this)
            {
                finishedTaskCount++;
            }
            PageDownloaded(this, pageUrl, "success");
        }

        //将相对路径转为绝对路径
        static private string FixUrl(string url, string baseUrl)
        {
            if (url.Contains("://"))
            {
                return url;
            }
            if (url.StartsWith("//"))
            {
                return "http:" + url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(baseUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = baseUrl.LastIndexOf('/');
                return FixUrl(url, baseUrl.Substring(0, idx));
            }

            if (url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), baseUrl);
            }

            int end = baseUrl.LastIndexOf("/");
            return baseUrl.Substring(0, end) + "/" + url;
        }
    }
   
}
