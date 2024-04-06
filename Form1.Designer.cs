
namespace LiteSurf
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wttrinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cNNLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riiConnect24BookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wiiNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frogFindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.loadProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFwd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLiteSurfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(-1, 53);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(624, 364);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sitesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutLiteSurfToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // sitesToolStripMenuItem
            // 
            this.sitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleToolStripMenuItem,
            this.wttrinToolStripMenuItem,
            this.cNNLiteToolStripMenuItem,
            this.riiConnect24BookmarksToolStripMenuItem,
            this.wiiNetToolStripMenuItem,
            this.frogFindToolStripMenuItem});
            this.sitesToolStripMenuItem.Name = "sitesToolStripMenuItem";
            this.sitesToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sitesToolStripMenuItem.Text = "Sites";
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.googleToolStripMenuItem.Text = "Google";
            this.googleToolStripMenuItem.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // wttrinToolStripMenuItem
            // 
            this.wttrinToolStripMenuItem.Name = "wttrinToolStripMenuItem";
            this.wttrinToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.wttrinToolStripMenuItem.Text = "wttr.in";
            this.wttrinToolStripMenuItem.Click += new System.EventHandler(this.wttrinToolStripMenuItem_Click);
            // 
            // cNNLiteToolStripMenuItem
            // 
            this.cNNLiteToolStripMenuItem.Name = "cNNLiteToolStripMenuItem";
            this.cNNLiteToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.cNNLiteToolStripMenuItem.Text = "CNN Lite";
            this.cNNLiteToolStripMenuItem.Click += new System.EventHandler(this.cNNLiteToolStripMenuItem_Click);
            // 
            // riiConnect24BookmarksToolStripMenuItem
            // 
            this.riiConnect24BookmarksToolStripMenuItem.Name = "riiConnect24BookmarksToolStripMenuItem";
            this.riiConnect24BookmarksToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.riiConnect24BookmarksToolStripMenuItem.Text = "RiiConnect24 Bookmarks";
            this.riiConnect24BookmarksToolStripMenuItem.Click += new System.EventHandler(this.riiConnect24BookmarksToolStripMenuItem_Click);
            // 
            // wiiNetToolStripMenuItem
            // 
            this.wiiNetToolStripMenuItem.Name = "wiiNetToolStripMenuItem";
            this.wiiNetToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.wiiNetToolStripMenuItem.Text = "WiiNet";
            this.wiiNetToolStripMenuItem.Click += new System.EventHandler(this.wiiNetToolStripMenuItem_Click);
            // 
            // frogFindToolStripMenuItem
            // 
            this.frogFindToolStripMenuItem.Name = "frogFindToolStripMenuItem";
            this.frogFindToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.frogFindToolStripMenuItem.Text = "FrogFind";
            this.frogFindToolStripMenuItem.Click += new System.EventHandler(this.frogFindToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProgress,
            this.labelTitle});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelTitle
            // 
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(38, 17);
            this.labelTitle.Text = "status";
            // 
            // loadProgress
            // 
            this.loadProgress.Name = "loadProgress";
            this.loadProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.Location = new System.Drawing.Point(175, 28);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(437, 20);
            this.urlTextBox.TabIndex = 3;
            this.urlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlTextBox_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFwd
            // 
            this.btnFwd.Location = new System.Drawing.Point(63, 27);
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(36, 23);
            this.btnFwd.TabIndex = 5;
            this.btnFwd.Text = "Fwd";
            this.btnFwd.UseVisualStyleBackColor = true;
            this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(105, 27);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(64, 23);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutLiteSurfToolStripMenuItem
            // 
            this.aboutLiteSurfToolStripMenuItem.Name = "aboutLiteSurfToolStripMenuItem";
            this.aboutLiteSurfToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutLiteSurfToolStripMenuItem.Text = "About LiteSurf";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnFwd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "Form1";
            this.Text = "LiteSurf";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelTitle;
        private System.Windows.Forms.ToolStripProgressBar loadProgress;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem sitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wttrinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cNNLiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riiConnect24BookmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wiiNetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frogFindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutLiteSurfToolStripMenuItem;
    }
}

