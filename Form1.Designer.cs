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
            this.button1 = new System.Windows.Forms.Button();
            this.URLLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ParsedWebStringBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // URLLabel
            // 
            this.URLLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.URLLabel.AutoSize = true;
            this.URLLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.URLLabel.Location = new System.Drawing.Point(129, 43);
            this.URLLabel.MinimumSize = new System.Drawing.Size(500, 20);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(500, 20);
            this.URLLabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL";
            // 
            // ParsedWebStringBox
            // 
            this.ParsedWebStringBox.Location = new System.Drawing.Point(25, 205);
            this.ParsedWebStringBox.Multiline = true;
            this.ParsedWebStringBox.Name = "ParsedWebStringBox";
            this.ParsedWebStringBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ParsedWebStringBox.Size = new System.Drawing.Size(757, 405);
            this.ParsedWebStringBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Web Page Text";
            // 
            // Web_Text_Parser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 679);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ParsedWebStringBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.URLLabel);
            this.Controls.Add(this.button1);
            this.Name = "Web_Text_Parser";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ParsedWebStringBox;
        private System.Windows.Forms.Label label3;
    }
}

