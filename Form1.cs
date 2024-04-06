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
            webBrowser1.StatusTextChanged += WebBrowser1_StatusTextChanged;
        }

        private void WebBrowser1_StatusTextChanged(object sender, EventArgs e)
        {
            labelTitle.Text = webBrowser1.StatusText;
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

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            urlTextBox.Text = webBrowser1.Url.ToString();
            string pageTitle = webBrowser1.DocumentTitle;

            if (!string.IsNullOrEmpty(pageTitle))
            {
                
                string formTitle = pageTitle + " - LiteSurf";
                Text = formTitle;
            }
            else
            {
                string formURL = "Title Unavailable" + " - LiteSurf";
                Text = formURL;
                
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

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://google.com");
        }

        private void wttrinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://wttr.in");
        }

        private void cNNLiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://lite.cnn.com/en");
        }

        private void riiConnect24BookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://bookmark.rc24.xyz");
        }

        private void wiiNetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://wiinet.xyz");
        }

        private void frogFindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://frogfind.com");
        }
    }
}
