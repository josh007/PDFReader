namespace PdfReader1
{
    partial class frmPdf
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
            this.btnRead = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRead2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtxtMain = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRead.Location = new System.Drawing.Point(367, 481);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "&Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(448, 481);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRead2
            // 
            this.btnRead2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRead2.Location = new System.Drawing.Point(286, 481);
            this.btnRead2.Name = "btnRead2";
            this.btnRead2.Size = new System.Drawing.Size(75, 23);
            this.btnRead2.TabIndex = 1;
            this.btnRead2.Text = "&Read2";
            this.btnRead2.UseVisualStyleBackColor = true;
            this.btnRead2.Click += new System.EventHandler(this.btnRead2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 463);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(503, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Normal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtMain
            // 
            this.txtMain.Font = new System.Drawing.Font("VG2 Main", 9F);
            this.txtMain.Location = new System.Drawing.Point(13, 6);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMain.Size = new System.Drawing.Size(484, 425);
            this.txtMain.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtxtMain);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(503, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RTF";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtxtMain
            // 
            this.rtxtMain.Font = new System.Drawing.Font("VG2 Main", 8.25F);
            this.rtxtMain.Location = new System.Drawing.Point(6, 6);
            this.rtxtMain.Name = "rtxtMain";
            this.rtxtMain.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtMain.Size = new System.Drawing.Size(491, 425);
            this.rtxtMain.TabIndex = 0;
            this.rtxtMain.Text = "asdfs\nsdf";
            // 
            // frmPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 510);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRead2);
            this.Controls.Add(this.btnRead);
            this.MaximizeBox = false;
            this.Name = "frmPdf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Reader";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRead2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtxtMain;
    }
}

