namespace PaulsURLPageReader
{
    partial class Web_Text_Parser
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
            this.btnGetPage = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.Label();
            this.lbURL = new System.Windows.Forms.Label();
            this.tbURLText = new System.Windows.Forms.TextBox();
            this.lbURLText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetPage
            // 
            this.btnGetPage.Location = new System.Drawing.Point(300, 108);
            this.btnGetPage.Name = "btnGetPage";
            this.btnGetPage.Size = new System.Drawing.Size(141, 41);
            this.btnGetPage.TabIndex = 0;
            this.btnGetPage.Text = "Get Page";
            this.btnGetPage.UseVisualStyleBackColor = true;
            this.btnGetPage.Click += new System.EventHandler(this.btnGetPage_Click);
            // 
            // tbURL
            // 
            this.tbURL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbURL.AutoSize = true;
            this.tbURL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbURL.Location = new System.Drawing.Point(129, 43);
            this.tbURL.MinimumSize = new System.Drawing.Size(500, 20);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(500, 20);
            this.tbURL.TabIndex = 1;
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(355, 22);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(36, 17);
            this.lbURL.TabIndex = 2;
            this.lbURL.Text = "URL";
            // 
            // tbURLText
            // 
            this.tbURLText.Location = new System.Drawing.Point(25, 205);
            this.tbURLText.Multiline = true;
            this.tbURLText.Name = "tbURLText";
            this.tbURLText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbURLText.Size = new System.Drawing.Size(757, 405);
            this.tbURLText.TabIndex = 3;
            // 
            // lbURLText
            // 
            this.lbURLText.AutoSize = true;
            this.lbURLText.Location = new System.Drawing.Point(319, 185);
            this.lbURLText.Name = "lbURLText";
            this.lbURLText.Size = new System.Drawing.Size(105, 17);
            this.lbURLText.TabIndex = 4;
            this.lbURLText.Text = "Web Page Text";
            // 
            // Web_Text_Parser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 679);
            this.Controls.Add(this.lbURLText);
            this.Controls.Add(this.tbURLText);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.btnGetPage);
            this.Name = "Web_Text_Parser";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetPage;
        private System.Windows.Forms.Label tbURL;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.TextBox tbURLText;
        private System.Windows.Forms.Label lbURLText;
    }
}

