using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LiteSurf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://rb1000.vercel.app/litesurf/");
        }

        private void urlTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(urlTextBox.Text);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnFwd_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void webBrowser1_FileDownload(object sender, EventArgs e)
        {
            Console.WriteLine("You are in the WebBrowser.FileDownload event.");
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            urlTextBox.Text = webBrowser1.Url.ToString();
            string pageTitle = webBrowser1.DocumentTitle;
            string currentUrl = e.Url.ToString();
            if (!string.IsNullOrEmpty(pageTitle))
            {
                labelTitle.Text = pageTitle;
            }
            else
            {
                labelTitle.Text = currentUrl;
            }
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.MaximumProgress > 0)
            {
                int progress = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
                loadProgress.Value = progress;
                if (progress >= 100)
                {
                    timer1.Start();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            loadProgress.Value = 0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
