namespace RandomCov2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txtCountPass = new System.Windows.Forms.TextBox();
			this.lblSifre = new System.Windows.Forms.Label();
			this.BtnStart = new System.Windows.Forms.Button();
			this.lblHarf = new System.Windows.Forms.Label();
			this.txtCountChar = new System.Windows.Forms.TextBox();
			this.chkSert = new System.Windows.Forms.CheckBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.lblUyari = new System.Windows.Forms.Label();
			this.lblDot1 = new System.Windows.Forms.Label();
			this.lblDot2 = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtCountPass
			// 
			this.txtCountPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.txtCountPass.Location = new System.Drawing.Point(135, 71);
			this.txtCountPass.Name = "txtCountPass";
			this.txtCountPass.Size = new System.Drawing.Size(304, 25);
			this.txtCountPass.TabIndex = 0;
			// 
			// lblSifre
			// 
			this.lblSifre.AutoSize = true;
			this.lblSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSifre.Location = new System.Drawing.Point(12, 74);
			this.lblSifre.Name = "lblSifre";
			this.lblSifre.Size = new System.Drawing.Size(40, 17);
			this.lblSifre.TabIndex = 3;
			this.lblSifre.Text = "ADET";
			// 
			// BtnStart
			// 
			this.BtnStart.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.BtnStart.FlatAppearance.BorderSize = 2;
			this.BtnStart.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnStart.Location = new System.Drawing.Point(12, 102);
			this.BtnStart.Name = "BtnStart";
			this.BtnStart.Size = new System.Drawing.Size(427, 27);
			this.BtnStart.TabIndex = 6;
			this.BtnStart.Text = "Start";
			this.BtnStart.UseVisualStyleBackColor = true;
			this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
			// 
			// lblHarf
			// 
			this.lblHarf.AutoSize = true;
			this.lblHarf.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblHarf.Location = new System.Drawing.Point(9, 38);
			this.lblHarf.Name = "lblHarf";
			this.lblHarf.Size = new System.Drawing.Size(114, 17);
			this.lblHarf.TabIndex = 10;
			this.lblHarf.Text = "KARAKTER SAYISI";
			// 
			// txtCountChar
			// 
			this.txtCountChar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.txtCountChar.Location = new System.Drawing.Point(135, 38);
			this.txtCountChar.Name = "txtCountChar";
			this.txtCountChar.Size = new System.Drawing.Size(304, 25);
			this.txtCountChar.TabIndex = 11;
			this.txtCountChar.Text = "8";
			this.txtCountChar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCountChar_KeyPress);
			// 
			// chkSert
			// 
			this.chkSert.AutoSize = true;
			this.chkSert.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.chkSert.ForeColor = System.Drawing.Color.Brown;
			this.chkSert.Location = new System.Drawing.Point(278, 7);
			this.chkSert.Name = "chkSert";
			this.chkSert.Size = new System.Drawing.Size(149, 23);
			this.chkSert.TabIndex = 12;
			this.chkSert.Text = "Daha Zor Şifre Üret";
			this.chkSert.UseVisualStyleBackColor = true;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 147);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(445, 25);
			this.toolStrip1.TabIndex = 14;
			this.toolStrip1.Text = "Bu Program Anıl SOYLU Tarafından Geliştirilmiştir.";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(269, 22);
			this.toolStripLabel1.Text = "Bu Program Anıl SOYLU Tarafından Geliştirilmiştir.";
			// 
			// lblUyari
			// 
			this.lblUyari.AutoSize = true;
			this.lblUyari.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.lblUyari.Location = new System.Drawing.Point(9, 7);
			this.lblUyari.Name = "lblUyari";
			this.lblUyari.Size = new System.Drawing.Size(0, 15);
			this.lblUyari.TabIndex = 15;
			// 
			// lblDot1
			// 
			this.lblDot1.AutoSize = true;
			this.lblDot1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDot1.Location = new System.Drawing.Point(121, 38);
			this.lblDot1.Name = "lblDot1";
			this.lblDot1.Size = new System.Drawing.Size(11, 17);
			this.lblDot1.TabIndex = 16;
			this.lblDot1.Text = ":";
			// 
			// lblDot2
			// 
			this.lblDot2.AutoSize = true;
			this.lblDot2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDot2.Location = new System.Drawing.Point(121, 74);
			this.lblDot2.Name = "lblDot2";
			this.lblDot2.Size = new System.Drawing.Size(11, 17);
			this.lblDot2.TabIndex = 17;
			this.lblDot2.Text = ":";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(445, 172);
			this.Controls.Add(this.lblDot2);
			this.Controls.Add(this.lblDot1);
			this.Controls.Add(this.lblUyari);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.chkSert);
			this.Controls.Add(this.txtCountChar);
			this.Controls.Add(this.lblHarf);
			this.Controls.Add(this.BtnStart);
			this.Controls.Add(this.lblSifre);
			this.Controls.Add(this.txtCountPass);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Password Generator";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCountPass;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label lblHarf;
        private System.Windows.Forms.TextBox txtCountChar;
        private System.Windows.Forms.CheckBox chkSert;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label lblUyari;
		private System.Windows.Forms.Label lblDot1;
		private System.Windows.Forms.Label lblDot2;
	}
}

