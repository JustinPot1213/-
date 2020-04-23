using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_9
{
    public partial class CrawlerForm : Form
    {

        

        public CrawlerForm()
        {
            InitializeComponent();
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            resultsTextBox.Text = "";
            Crawler crawler = new Crawler(startUrlTextBox.Text);
            crawler.ShowMessages += Crawler_ShowMessages;
            new Thread(crawler.Crawl).Start();
            resultsTextBox.Text += 
                "开始爬行了.... " + System.Environment.NewLine;

        }

        private void Crawler_ShowMessages(string url,string status)
        {
            if (this.resultsTextBox.InvokeRequired)
            {
                Action<String, String> action = this.AddUrl;
                this.Invoke(action, new object[] { url, status });
            }
            else
            {
                AddUrl(url, status);
            }
        }

        private void AddUrl(string url, string status)
        {
            resultsTextBox.Text += url;
            resultsTextBox.Text += status + System.Environment.NewLine;
        }

    }


}
