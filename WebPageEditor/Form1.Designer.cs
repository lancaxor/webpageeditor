namespace WebPageEditor
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
            this.tbHtml = new System.Windows.Forms.TextBox();
            this.tbCss = new System.Windows.Forms.TextBox();
            this.previewBrowser = new System.Windows.Forms.WebBrowser();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.browserPanel = new System.Windows.Forms.Panel();
            this.browserWidth = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.browserHeight = new System.Windows.Forms.TextBox();
            this.browserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbHtml
            // 
            this.tbHtml.Location = new System.Drawing.Point(0, 0);
            this.tbHtml.Multiline = true;
            this.tbHtml.Name = "tbHtml";
            this.tbHtml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbHtml.Size = new System.Drawing.Size(493, 340);
            this.tbHtml.TabIndex = 0;
            this.tbHtml.TextChanged += new System.EventHandler(this.tbHtml_TextChanged);
            this.tbHtml.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEditor_KeyDown);
            // 
            // tbCss
            // 
            this.tbCss.Location = new System.Drawing.Point(0, 347);
            this.tbCss.Multiline = true;
            this.tbCss.Name = "tbCss";
            this.tbCss.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCss.Size = new System.Drawing.Size(493, 360);
            this.tbCss.TabIndex = 1;
            this.tbCss.TextChanged += new System.EventHandler(this.tbCss_TextChanged);
            this.tbCss.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEditor_KeyDown);
            // 
            // previewBrowser
            // 
            this.previewBrowser.Location = new System.Drawing.Point(3, 0);
            this.previewBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.previewBrowser.Name = "previewBrowser";
            this.previewBrowser.ScrollBarsEnabled = false;
            this.previewBrowser.Size = new System.Drawing.Size(479, 675);
            this.previewBrowser.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(898, 684);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 28);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // browserPanel
            // 
            this.browserPanel.AutoScroll = true;
            this.browserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.browserPanel.Controls.Add(this.previewBrowser);
            this.browserPanel.Location = new System.Drawing.Point(499, 0);
            this.browserPanel.Name = "browserPanel";
            this.browserPanel.Size = new System.Drawing.Size(485, 678);
            this.browserPanel.TabIndex = 4;
            // 
            // browserWidth
            // 
            this.browserWidth.Location = new System.Drawing.Point(502, 685);
            this.browserWidth.Name = "browserWidth";
            this.browserWidth.Size = new System.Drawing.Size(100, 22);
            this.browserWidth.TabIndex = 5;
            this.browserWidth.Text = "1024";
            this.browserWidth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(608, 688);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 17);
            this.xLabel.TabIndex = 6;
            this.xLabel.Text = "x";
            // 
            // browserHeight
            // 
            this.browserHeight.Location = new System.Drawing.Point(628, 685);
            this.browserHeight.Name = "browserHeight";
            this.browserHeight.Size = new System.Drawing.Size(100, 22);
            this.browserHeight.TabIndex = 7;
            this.browserHeight.Text = "800";
            this.browserHeight.TextChanged += new System.EventHandler(this.browserHeight_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 719);
            this.Controls.Add(this.browserHeight);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.browserWidth);
            this.Controls.Add(this.browserPanel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbCss);
            this.Controls.Add(this.tbHtml);
            this.Name = "Form1";
            this.Text = "WebDesign Editor";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.browserPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHtml;
        private System.Windows.Forms.TextBox tbCss;
        private System.Windows.Forms.WebBrowser previewBrowser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel browserPanel;
        private System.Windows.Forms.TextBox browserWidth;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox browserHeight;
    }
}

