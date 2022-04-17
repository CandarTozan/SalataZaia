
namespace SalataZaia.Desktop
{
    partial class OyunBitti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyunBitti));
            this.oyunBittiPanel = new System.Windows.Forms.Panel();
            this.cıkısButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oyunBittiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // oyunBittiPanel
            // 
            this.oyunBittiPanel.BackColor = System.Drawing.Color.Crimson;
            this.oyunBittiPanel.Controls.Add(this.cıkısButton);
            this.oyunBittiPanel.Controls.Add(this.pictureBox1);
            this.oyunBittiPanel.Controls.Add(this.label1);
            this.oyunBittiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oyunBittiPanel.Location = new System.Drawing.Point(0, 0);
            this.oyunBittiPanel.Name = "oyunBittiPanel";
            this.oyunBittiPanel.Size = new System.Drawing.Size(536, 200);
            this.oyunBittiPanel.TabIndex = 0;
            // 
            // cıkısButton
            // 
            this.cıkısButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cıkısButton.Location = new System.Drawing.Point(115, 130);
            this.cıkısButton.Name = "cıkısButton";
            this.cıkısButton.Size = new System.Drawing.Size(135, 23);
            this.cıkısButton.TabIndex = 2;
            this.cıkısButton.Text = "Çıkış";
            this.cıkısButton.UseVisualStyleBackColor = true;
            this.cıkısButton.Click += new System.EventHandler(this.cıkısButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(367, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZAMANIN BİTTİĞİ İÇİN OYUN BİTTİ\r\n";
            // 
            // OyunBitti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 200);
            this.Controls.Add(this.oyunBittiPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OyunBitti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OyunBitti";
            this.oyunBittiPanel.ResumeLayout(false);
            this.oyunBittiPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel oyunBittiPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cıkısButton;
    }
}