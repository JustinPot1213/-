using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Homework_10 {
  public partial class Form1 : Form {
    BindingSource resultBindingSource = new BindingSource();
    Crawler crawler = new Crawler();
    Thread thread = null;
    Stopwatch sw;

        public Form1() {
      InitializeComponent();
      dgvResult.DataSource = resultBindingSource;
      crawler.PageDownloaded += Crawler_PageDownloaded;
      crawler.CrawlerStopped += Crawler_CrawlerStopped;
    }

    private void Crawler_CrawlerStopped(Crawler obj) {
      sw.Stop();
      Action action = () => lblInfo.Text = 
        "爬虫已停止,持续时间:" + sw.ElapsedMilliseconds+"ms";
      if (this.InvokeRequired) {
        this.Invoke(action);
      }else {
        action();
      }
    }

        private void Crawler_PageDownloaded(Crawler crawler, string url, string info) {
            lock (resultBindingSource)
            {
                var pageInfo = new { Index = resultBindingSource.Count + 1, URL = url, Status = info };
                Action action = () => { resultBindingSource.Add(pageInfo); };
                if (this.InvokeRequired)
                {
                    this.Invoke(action);
                }
                else
                {
                    action();
                }
            }
     
        }


    private void btnStart_Click(object sender, EventArgs e) {
      resultBindingSource.Clear();
      crawler.StartURL = txtUrl.Text;

      Match match = Regex.Match(crawler.StartURL, Crawler.urlParseRegex);
      if (match.Length == 0) return;
      string host = match.Groups["host"].Value;
      crawler.HostFilter = "^" + host + "$";
      crawler.FileFilter = ".html?$";
      
      if (thread != null) {
        thread.Abort();
      }
      thread = new Thread(crawler.Start);
      thread.Start();
      lblInfo.Text = "爬虫已启动....";
      sw = new Stopwatch();
      sw.Start();
    }

        private void parallelButton_Click(object sender, EventArgs e)
        {
            resultBindingSource.Clear();
            crawler.StartURL = txtUrl.Text;

            Match match = Regex.Match(crawler.StartURL, Crawler.urlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            crawler.HostFilter = "^" + host + "$";
            crawler.FileFilter = ".html?$";
            if (thread != null)
            {
                thread.Abort();
            }
            thread = new Thread(crawler.ParallelStart);
            thread.Start();
            lblInfo.Text = "并行爬虫已启动....";
            sw = new Stopwatch();
            sw.Start();
        }
    }
}
