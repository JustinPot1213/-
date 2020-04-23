using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Homework_9
{
    class Crawler
    {

        private Hashtable urls = new Hashtable();
        private int count = 0;
        private int[] checkLast = new int[15]
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        private string[] lastUrl = new string[15];
        private string source;
        private string startUrl;
        public event Action<string, string> ShowMessages;


        public Crawler(string startUrl)
        {
            this.startUrl = startUrl;
            this.source = GetSource(this.startUrl);
            this.urls.Add(startUrl, false);//加入初始页面
        }

        public void Crawl() {
            ShowMessages("本次爬行源地址是：" + source, "");
            string last = startUrl;
            while (true) {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if (!((bool)urls[url]) &&
                        (url == startUrl)) current = url;
                    if ((bool)urls[url] || 
                        !(CheckHtml(url)) || !(CheckSource(this.source,url)))
                        continue;
                    current = url;
                }
                if (current == null || count > 14) break;
                string html = DownLoad(current); // 下载
                urls[current] = true;
                lastUrl[count] = current;
                int temp = 0;
                for (int i=0; i<count;i++)
                {
                    temp += checkLast[i];
                    if (count <= temp)
                    {
                        last = lastUrl[i];
                        break;
                    }
                }
                checkLast[count] = Parse(current, last, html);//解析,并加入新的链接
                count++;
            }
            ShowMessages("", "爬行结束");
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                ShowMessages("爬行" + url + "页面!", " 成功");
                return html;
            }
            catch (Exception ex) {
                ShowMessages
                    ("爬行" + url + "页面!", " 失败 "+ex.Message);
                return "";
            }
        }

        private int Parse(string current, string last, string html)
        {
            int urlAddedNums = 0;

            string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+[""']";

            //string rexAbsolute = @"://([\w\d.]*)";
            string rexSource_1 = @"^../([/\w\d.]*)";
            string rexSource_2 = @"^./([/\w\d.]*)";
            string rexLast_1 = @"^/([/\w\d.]*)";
            string rexLast_2 = @"^([/\w\d.]*)";

            string absoluteStrRef;

            string httpOrhttpsRex = @"([\w]*)://([\w\d.]*)/";
            string httpOrhttps =
                Regex.Match(last, httpOrhttpsRex).Groups[1].Value;

            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                  .Trim('"', '\"', '#', '>');

                if (strRef.Length == 0) continue;

                if (Regex.IsMatch(strRef, rexSource_1))
                {
                    strRef = Regex.Match(strRef, rexSource_1).Groups[1].Value;
                    absoluteStrRef = httpOrhttps + @"://" + GetSource(last) + @"/" + strRef;
                }
                else if (Regex.IsMatch(strRef, rexSource_2))
                {
                    strRef = Regex.Match(strRef, rexSource_2).Groups[1].Value;
                    absoluteStrRef = httpOrhttps + @"://" + GetSource(current) + @"/" + strRef;
                }
                else if (Regex.IsMatch(strRef, rexLast_1))
                {
                    strRef = Regex.Match(strRef, rexLast_1).Groups[1].Value;
                    absoluteStrRef = GetLast(last) + strRef;
                }
                else if (!Regex.IsMatch(strRef, source) &&
                    Regex.IsMatch(strRef, rexLast_2))
                {
                    strRef = Regex.Match(strRef, rexLast_2).Groups[1].Value;
                    absoluteStrRef = GetLast(current) + strRef;
                }
                else
                {
                    absoluteStrRef = strRef;
                }

                if (urls[absoluteStrRef] == null)
                {
                    urls[absoluteStrRef] = false;
                    urlAddedNums++;
                }

            }
            return urlAddedNums;
        }

        private bool CheckHtml(string url)
        {
            string htmlRex_1 = @".htm";
            //string htmlRex_2 = @"/$";
            return (Regex.IsMatch(url, htmlRex_1));
            //|| Regex.IsMatch(url, htmlRex_2));
        }

        bool CheckSource(string source,string url)
        {
            return Regex.IsMatch(url, source);
        }

        string GetSource(string startUrl)
        {
            string sourceRex = @"://([\w\d.]*)/";
            string source = new Regex(sourceRex).Match(startUrl).Groups[1].Value;
            return source;
        }

        string GetLast(string url)
        {
            int last = url.LastIndexOf('/');
            return url.Substring(0, last + 1);
        }
    }
}
