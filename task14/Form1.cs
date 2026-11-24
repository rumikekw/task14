using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace task14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.Navigate("https://www.google.az");
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.instagram.com");
        }

        private void faceBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.facebook.com");
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.youtube.com");
        }

        private void telegramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.telegram.org");
        }
        private ColorDialog colorDialog1 = new ColorDialog();
        private void arxaPlanRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.BackColor = colorDialog1.Color;
                foreach (ToolStripMenuItem item in menuStrip1.Items)
                {
                    item.DropDown.BackColor = colorDialog1.Color;
                }
            }
        }

        private void yaziRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.ForeColor = colorDialog1.Color;
                foreach (ToolStripMenuItem item in menuStrip1.Items)
                {
                    item.ForeColor = colorDialog1.Color;
                    foreach (ToolStripItem subItem in item.DropDownItems)
                    {
                        subItem.ForeColor = colorDialog1.Color;
                    }
                }
            }
        }

        private void cixisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Cixis edilsinmi?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        private void sehifeniBoyutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.ZoomFactor += 0.1;
        }

        private void sehifeniKiciltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webView21.ZoomFactor > 0.25)
            {
                webView21.ZoomFactor -= 0.1;
            }
        }
    }
}
