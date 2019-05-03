namespace FileBrowser
{
    partial class FileBrowser
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
            this.txtSearchFile = new System.Windows.Forms.TextBox();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.lbxResults = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearchFile
            // 
            this.txtSearchFile.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSearchFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchFile.Location = new System.Drawing.Point(24, 37);
            this.txtSearchFile.Name = "txtSearchFile";
            this.txtSearchFile.Size = new System.Drawing.Size(136, 14);
            this.txtSearchFile.TabIndex = 0;
            this.txtSearchFile.TextChanged += new System.EventHandler(this.txtSearchFile_TextChanged);
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchFile.Location = new System.Drawing.Point(166, 26);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(75, 25);
            this.btnSearchFile.TabIndex = 2;
            this.btnSearchFile.Text = "Search";
            this.btnSearchFile.UseVisualStyleBackColor = false;
            this.btnSearchFile.Click += new System.EventHandler(this.btnSearchFile_Click);
            // 
            // lbxResults
            // 
            this.lbxResults.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbxResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxResults.FormattingEnabled = true;
            this.lbxResults.ItemHeight = 14;
            this.lbxResults.Location = new System.Drawing.Point(24, 97);
            this.lbxResults.Name = "lbxResults";
            this.lbxResults.Size = new System.Drawing.Size(217, 168);
            this.lbxResults.TabIndex = 4;
            this.lbxResults.DoubleClick += new System.EventHandler(this.lbxResults_DoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(166, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(266, 279);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbxResults);
            this.Controls.Add(this.btnSearchFile);
            this.Controls.Add(this.txtSearchFile);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "FileBrowser";
            this.Opacity = 0.9D;
            this.Padding = new System.Windows.Forms.Padding(0, 0, 20, 11);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Browser";
            this.Load += new System.EventHandler(this.FileBrowser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchFile;
        private System.Windows.Forms.Button btnSearchFile;
        private System.Windows.Forms.ListBox lbxResults;
        private System.Windows.Forms.Button button1;
    }
}

