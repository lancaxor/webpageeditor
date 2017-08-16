using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace WebPageEditor
{
    public partial class Form1 : Form
    {
        private String htmlText = "";
        private String cssText = "";
        private String htmlFormat = "<!DOCTYPE html><HTML><HEAD><STYLE>{1}</STYLE></HEAD><BODY>{0}</BODY></HTML>";
        private Boolean viewUpdated = true;
        private BackgroundWorker webViewUpdater;
        private DoWorkEventHandler delegateUpdater;

        public Form1()
        {
            InitializeComponent();
            this.webViewUpdater = new BackgroundWorker();
            this.delegateUpdater = new DoWorkEventHandler(backgroundHandler);
            this.webViewUpdater.DoWork += this.delegateUpdater;
            this.sizeControls();
            this.initValues();
        }

        public void sizeControls()
        {
            this.tbHtml.Location = new Point{ X = 0, Y = 0};
            this.tbHtml.Size = new Size { Width = (this.Width / 2 - 2), Height = (this.Height / 2 - 20) };

            this.tbCss.Location = new Point { X = 0, Y = (this.tbHtml.Height + 4) };
            this.tbCss.Size = new Size { Width = this.tbHtml.Width, Height = this.tbHtml.Height };

            this.browserPanel.Location = new Point { X = this.tbHtml.Right + 2, Y = 0 };
            this.browserPanel.Size = new Size { Width = (this.Width / 2 - 2), Height = (this.Height - this.btnRefresh.Height - 36) };

            this.browserWidth.Location = new Point { X = this.tbCss.Right + 2, Y = (this.browserPanel.Bottom +  4) };
            this.xLabel.Location = new Point { X = this.browserWidth.Right + 2, Y = this.browserWidth.Location.Y };
            this.browserHeight.Location = new Point { X = this.xLabel.Right + 2, Y = this.browserWidth.Location.Y };

            this.btnRefresh.Location = new Point { X = (this.browserPanel.Right - this.btnRefresh.Width - 7), Y = this.browserPanel.Bottom + 4};
        }

        public void initValues()
        {
            this.browserWidth.Text = this.previewBrowser.Width.ToString();
            this.browserHeight.Text = this.previewBrowser.Height.ToString();

            this.browserWidth.MouseWheel += new MouseEventHandler(browserSize_MouseWheel);
            this.browserHeight.MouseWheel += new MouseEventHandler(browserSize_MouseWheel);

            this.tbCss.MaxLength = Int32.MaxValue;
            this.tbHtml.MaxLength = Int32.MaxValue;
        }

        void browserSize_MouseWheel(object sender, MouseEventArgs e)
        {
            Int32 value;
            Boolean result = Int32.TryParse((sender as TextBox).Text, out value);
            if (!result || value < 0)
            {
                (sender as TextBox).Text = "0";
            }
            else
            {
                (sender as TextBox).Text = e.Delta > 0 ? (value + 10).ToString() : (value - 10).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.htmlText = this.tbHtml.Text;
            this.cssText = this.tbCss.Text;
            this.setCode(this.htmlText, this.cssText);
            this.previewBrowser.Update();
        }

        protected void setCode(String html, String css = "")
        {
            this.previewBrowser.DocumentText = String.Format(this.htmlFormat, html, css);
        }

        protected void backgroundHandler(object sender, DoWorkEventArgs args)
        {
            do
            {
                Thread.Sleep(500);
                this.previewBrowser.DocumentText = String.Format(this.htmlFormat, this.htmlText, this.cssText);
                this.previewBrowser.Document.Window.ResizeTo(10, 10);
                this.viewUpdated = true;
            } while (!this.viewUpdated);
        }

        protected void refreshWebView()
        {
            this.viewUpdated = false;
            if (!this.webViewUpdater.IsBusy)
            {
                this.webViewUpdater.RunWorkerAsync();
            }
        }

        private void tbHtml_TextChanged(object sender, EventArgs e)
        {
            this.htmlText = (sender as TextBox).Text;
            this.refreshWebView();
        }

        private void tbCss_TextChanged(object sender, EventArgs e)
        {
            this.cssText = (sender as TextBox).Text;
            this.refreshWebView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Int32 width;
            Boolean result = Int32.TryParse((sender as TextBox).Text, out width);
            if (!result)
            {
                (sender as TextBox).Text = this.previewBrowser.Width.ToString();
            }
            else
            {
                this.previewBrowser.Width = width;
            }
        }

        private void browserHeight_TextChanged(object sender, EventArgs e)
        {
            Int32 height;
            Boolean result = Int32.TryParse((sender as TextBox).Text, out height);
            if (!result)
            {
                (sender as TextBox).Text = this.previewBrowser.Height.ToString();
            }
            else
            {
                this.previewBrowser.Height = height;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.sizeControls();
        }

        private void tbEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                (sender as TextBox).SelectAll();
            }
        }
    }
}
