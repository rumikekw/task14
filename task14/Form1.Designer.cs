namespace task14
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            socialMediaToolStripMenuItem = new ToolStripMenuItem();
            instagramToolStripMenuItem = new ToolStripMenuItem();
            faceBookToolStripMenuItem = new ToolStripMenuItem();
            youtubeToolStripMenuItem = new ToolStripMenuItem();
            telegramToolStripMenuItem = new ToolStripMenuItem();
            aletlerToolStripMenuItem = new ToolStripMenuItem();
            arxaPlanRengiToolStripMenuItem = new ToolStripMenuItem();
            yaziRengiToolStripMenuItem = new ToolStripMenuItem();
            sehifeniBoyutToolStripMenuItem = new ToolStripMenuItem();
            sehifeniKiciltToolStripMenuItem = new ToolStripMenuItem();
            cixisToolStripMenuItem = new ToolStripMenuItem();
            elaqeToolStripMenuItem = new ToolStripMenuItem();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { socialMediaToolStripMenuItem, aletlerToolStripMenuItem, elaqeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(975, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // socialMediaToolStripMenuItem
            // 
            socialMediaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { instagramToolStripMenuItem, faceBookToolStripMenuItem, youtubeToolStripMenuItem, telegramToolStripMenuItem });
            socialMediaToolStripMenuItem.Name = "socialMediaToolStripMenuItem";
            socialMediaToolStripMenuItem.Size = new Size(86, 20);
            socialMediaToolStripMenuItem.Text = "Social media";
            // 
            // instagramToolStripMenuItem
            // 
            instagramToolStripMenuItem.Image = (Image)resources.GetObject("instagramToolStripMenuItem.Image");
            instagramToolStripMenuItem.Name = "instagramToolStripMenuItem";
            instagramToolStripMenuItem.Size = new Size(180, 22);
            instagramToolStripMenuItem.Text = "Instagram";
            instagramToolStripMenuItem.Click += instagramToolStripMenuItem_Click;
            // 
            // faceBookToolStripMenuItem
            // 
            faceBookToolStripMenuItem.Image = (Image)resources.GetObject("faceBookToolStripMenuItem.Image");
            faceBookToolStripMenuItem.Name = "faceBookToolStripMenuItem";
            faceBookToolStripMenuItem.Size = new Size(180, 22);
            faceBookToolStripMenuItem.Text = "FaceBook";
            faceBookToolStripMenuItem.Click += faceBookToolStripMenuItem_Click;
            // 
            // youtubeToolStripMenuItem
            // 
            youtubeToolStripMenuItem.Image = (Image)resources.GetObject("youtubeToolStripMenuItem.Image");
            youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            youtubeToolStripMenuItem.Size = new Size(180, 22);
            youtubeToolStripMenuItem.Text = "Youtube";
            youtubeToolStripMenuItem.Click += youtubeToolStripMenuItem_Click;
            // 
            // telegramToolStripMenuItem
            // 
            telegramToolStripMenuItem.Image = (Image)resources.GetObject("telegramToolStripMenuItem.Image");
            telegramToolStripMenuItem.Name = "telegramToolStripMenuItem";
            telegramToolStripMenuItem.Size = new Size(180, 22);
            telegramToolStripMenuItem.Text = "Telegram";
            telegramToolStripMenuItem.Click += telegramToolStripMenuItem_Click;
            // 
            // aletlerToolStripMenuItem
            // 
            aletlerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arxaPlanRengiToolStripMenuItem, yaziRengiToolStripMenuItem, sehifeniBoyutToolStripMenuItem, sehifeniKiciltToolStripMenuItem, cixisToolStripMenuItem });
            aletlerToolStripMenuItem.Name = "aletlerToolStripMenuItem";
            aletlerToolStripMenuItem.Size = new Size(53, 20);
            aletlerToolStripMenuItem.Text = "Aletler";
            // 
            // arxaPlanRengiToolStripMenuItem
            // 
            arxaPlanRengiToolStripMenuItem.Name = "arxaPlanRengiToolStripMenuItem";
            arxaPlanRengiToolStripMenuItem.Size = new Size(180, 22);
            arxaPlanRengiToolStripMenuItem.Text = "Arxa plan rengi";
            arxaPlanRengiToolStripMenuItem.Click += arxaPlanRengiToolStripMenuItem_Click;
            // 
            // yaziRengiToolStripMenuItem
            // 
            yaziRengiToolStripMenuItem.Name = "yaziRengiToolStripMenuItem";
            yaziRengiToolStripMenuItem.Size = new Size(180, 22);
            yaziRengiToolStripMenuItem.Text = "yazi rengi";
            yaziRengiToolStripMenuItem.Click += yaziRengiToolStripMenuItem_Click;
            // 
            // sehifeniBoyutToolStripMenuItem
            // 
            sehifeniBoyutToolStripMenuItem.Name = "sehifeniBoyutToolStripMenuItem";
            sehifeniBoyutToolStripMenuItem.Size = new Size(180, 22);
            sehifeniBoyutToolStripMenuItem.Text = "Sehifeni boyut";
            sehifeniBoyutToolStripMenuItem.Click += sehifeniBoyutToolStripMenuItem_Click;
            // 
            // sehifeniKiciltToolStripMenuItem
            // 
            sehifeniKiciltToolStripMenuItem.Name = "sehifeniKiciltToolStripMenuItem";
            sehifeniKiciltToolStripMenuItem.Size = new Size(180, 22);
            sehifeniKiciltToolStripMenuItem.Text = "Sehifeni kicilt";
            sehifeniKiciltToolStripMenuItem.Click += sehifeniKiciltToolStripMenuItem_Click;
            // 
            // cixisToolStripMenuItem
            // 
            cixisToolStripMenuItem.Name = "cixisToolStripMenuItem";
            cixisToolStripMenuItem.Size = new Size(180, 22);
            cixisToolStripMenuItem.Text = "Cixis";
            cixisToolStripMenuItem.Click += cixisToolStripMenuItem_Click;
            // 
            // elaqeToolStripMenuItem
            // 
            elaqeToolStripMenuItem.Name = "elaqeToolStripMenuItem";
            elaqeToolStripMenuItem.Size = new Size(47, 20);
            elaqeToolStripMenuItem.Text = "Elaqe";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(0, 27);
            webView21.Name = "webView21";
            webView21.Size = new Size(975, 583);
            webView21.TabIndex = 1;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 610);
            Controls.Add(webView21);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem socialMediaToolStripMenuItem;
        private ToolStripMenuItem instagramToolStripMenuItem;
        private ToolStripMenuItem faceBookToolStripMenuItem;
        private ToolStripMenuItem youtubeToolStripMenuItem;
        private ToolStripMenuItem telegramToolStripMenuItem;
        private ToolStripMenuItem aletlerToolStripMenuItem;
        private ToolStripMenuItem elaqeToolStripMenuItem;
        private ToolStripMenuItem arxaPlanRengiToolStripMenuItem;
        private ToolStripMenuItem yaziRengiToolStripMenuItem;
        private ToolStripMenuItem cixisToolStripMenuItem;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private ToolStripMenuItem sehifeniBoyutToolStripMenuItem;
        private ToolStripMenuItem sehifeniKiciltToolStripMenuItem;
    }
}
