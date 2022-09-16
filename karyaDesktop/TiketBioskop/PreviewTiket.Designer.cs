namespace TiketBioskop
{
    partial class PreviewTiket
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
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_Studio = new System.Windows.Forms.Label();
            this.lblLinkBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 352);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harga : ";
            // 
            // LBL_Studio
            // 
            this.LBL_Studio.AutoSize = true;
            this.LBL_Studio.Location = new System.Drawing.Point(80, 311);
            this.LBL_Studio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Studio.Name = "LBL_Studio";
            this.LBL_Studio.Size = new System.Drawing.Size(63, 20);
            this.LBL_Studio.TabIndex = 1;
            this.LBL_Studio.Text = "Studio :";
            // 
            // lblLinkBack
            // 
            this.lblLinkBack.AutoSize = true;
            this.lblLinkBack.Location = new System.Drawing.Point(24, 26);
            this.lblLinkBack.Name = "lblLinkBack";
            this.lblLinkBack.Size = new System.Drawing.Size(96, 20);
            this.lblLinkBack.TabIndex = 2;
            this.lblLinkBack.TabStop = true;
            this.lblLinkBack.Text = "<<< Kembali";
            this.lblLinkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkBack_LinkClicked);
            // 
            // PreviewTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 692);
            this.Controls.Add(this.lblLinkBack);
            this.Controls.Add(this.LBL_Studio);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PreviewTiket";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LBL_Studio;
        private System.Windows.Forms.LinkLabel lblLinkBack;
    }
}