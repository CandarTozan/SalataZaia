
namespace SalataZaia.Desktop
{
    partial class OyunForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyunForm));
            this.bilgiPAnel = new System.Windows.Forms.Panel();
            this.marulSayiaLabel = new System.Windows.Forms.Label();
            this.soganSayiLabel = new System.Windows.Forms.Label();
            this.kaseSayiLabel = new System.Windows.Forms.Label();
            this.bilgiUrunLabel = new System.Windows.Forms.Label();
            this.bilgiAdLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bilgiKalan = new System.Windows.Forms.Label();
            this.bilgiyapilan = new System.Windows.Forms.Label();
            this.bilgiSureLabel = new System.Windows.Forms.Label();
            this.lblsure = new System.Windows.Forms.Label();
            this.oyunAlanPanel = new System.Windows.Forms.Panel();
            this.gecenSureTimer = new System.Windows.Forms.Timer(this.components);
            this.guncellemeTimer = new System.Windows.Forms.Timer(this.components);
            this.bilgiSkor = new System.Windows.Forms.Label();
            this.bilgiPAnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bilgiPAnel
            // 
            this.bilgiPAnel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bilgiPAnel.Controls.Add(this.bilgiSkor);
            this.bilgiPAnel.Controls.Add(this.marulSayiaLabel);
            this.bilgiPAnel.Controls.Add(this.soganSayiLabel);
            this.bilgiPAnel.Controls.Add(this.kaseSayiLabel);
            this.bilgiPAnel.Controls.Add(this.bilgiUrunLabel);
            this.bilgiPAnel.Controls.Add(this.bilgiAdLabel);
            this.bilgiPAnel.Controls.Add(this.pictureBox3);
            this.bilgiPAnel.Controls.Add(this.pictureBox2);
            this.bilgiPAnel.Controls.Add(this.pictureBox1);
            this.bilgiPAnel.Controls.Add(this.bilgiKalan);
            this.bilgiPAnel.Controls.Add(this.bilgiyapilan);
            this.bilgiPAnel.Controls.Add(this.bilgiSureLabel);
            this.bilgiPAnel.Controls.Add(this.lblsure);
            this.bilgiPAnel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bilgiPAnel.Location = new System.Drawing.Point(485, 0);
            this.bilgiPAnel.Name = "bilgiPAnel";
            this.bilgiPAnel.Size = new System.Drawing.Size(207, 681);
            this.bilgiPAnel.TabIndex = 0;
            // 
            // marulSayiaLabel
            // 
            this.marulSayiaLabel.AutoSize = true;
            this.marulSayiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.marulSayiaLabel.Location = new System.Drawing.Point(131, 454);
            this.marulSayiaLabel.Name = "marulSayiaLabel";
            this.marulSayiaLabel.Size = new System.Drawing.Size(24, 26);
            this.marulSayiaLabel.TabIndex = 11;
            this.marulSayiaLabel.Text = "0";
            // 
            // soganSayiLabel
            // 
            this.soganSayiLabel.AutoSize = true;
            this.soganSayiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soganSayiLabel.Location = new System.Drawing.Point(131, 383);
            this.soganSayiLabel.Name = "soganSayiLabel";
            this.soganSayiLabel.Size = new System.Drawing.Size(24, 26);
            this.soganSayiLabel.TabIndex = 10;
            this.soganSayiLabel.Text = "0";
            // 
            // kaseSayiLabel
            // 
            this.kaseSayiLabel.AutoSize = true;
            this.kaseSayiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaseSayiLabel.Location = new System.Drawing.Point(131, 312);
            this.kaseSayiLabel.Name = "kaseSayiLabel";
            this.kaseSayiLabel.Size = new System.Drawing.Size(24, 26);
            this.kaseSayiLabel.TabIndex = 9;
            this.kaseSayiLabel.Text = "0";
            // 
            // bilgiUrunLabel
            // 
            this.bilgiUrunLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bilgiUrunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiUrunLabel.Location = new System.Drawing.Point(21, 631);
            this.bilgiUrunLabel.Name = "bilgiUrunLabel";
            this.bilgiUrunLabel.Size = new System.Drawing.Size(174, 20);
            this.bilgiUrunLabel.TabIndex = 8;
            this.bilgiUrunLabel.Text = "Ürün";
            this.bilgiUrunLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bilgiAdLabel
            // 
            this.bilgiAdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bilgiAdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiAdLabel.Location = new System.Drawing.Point(21, 583);
            this.bilgiAdLabel.Name = "bilgiAdLabel";
            this.bilgiAdLabel.Size = new System.Drawing.Size(174, 20);
            this.bilgiAdLabel.TabIndex = 7;
            this.bilgiAdLabel.Text = "Müşteri";
            this.bilgiAdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(31, 429);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 362);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bilgiKalan
            // 
            this.bilgiKalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiKalan.Location = new System.Drawing.Point(27, 209);
            this.bilgiKalan.Name = "bilgiKalan";
            this.bilgiKalan.Size = new System.Drawing.Size(157, 20);
            this.bilgiKalan.TabIndex = 3;
            this.bilgiKalan.Text = "Kalan : 0";
            this.bilgiKalan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bilgiyapilan
            // 
            this.bilgiyapilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiyapilan.Location = new System.Drawing.Point(27, 163);
            this.bilgiyapilan.Name = "bilgiyapilan";
            this.bilgiyapilan.Size = new System.Drawing.Size(157, 20);
            this.bilgiyapilan.TabIndex = 2;
            this.bilgiyapilan.Text = "Toplam Yapılan : 0";
            this.bilgiyapilan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bilgiSureLabel
            // 
            this.bilgiSureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiSureLabel.Location = new System.Drawing.Point(43, 74);
            this.bilgiSureLabel.Name = "bilgiSureLabel";
            this.bilgiSureLabel.Size = new System.Drawing.Size(129, 46);
            this.bilgiSureLabel.TabIndex = 1;
            this.bilgiSureLabel.Text = "0";
            this.bilgiSureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsure
            // 
            this.lblsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsure.Location = new System.Drawing.Point(39, 23);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(133, 20);
            this.lblsure.TabIndex = 0;
            this.lblsure.Text = "Kalan Süre (sn)";
            // 
            // oyunAlanPanel
            // 
            this.oyunAlanPanel.BackColor = System.Drawing.Color.SeaGreen;
            this.oyunAlanPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oyunAlanPanel.Location = new System.Drawing.Point(0, 0);
            this.oyunAlanPanel.Name = "oyunAlanPanel";
            this.oyunAlanPanel.Size = new System.Drawing.Size(485, 681);
            this.oyunAlanPanel.TabIndex = 1;
            // 
            // gecenSureTimer
            // 
            this.gecenSureTimer.Enabled = true;
            this.gecenSureTimer.Interval = 1000;
            this.gecenSureTimer.Tick += new System.EventHandler(this.gecenSureTimer_Tick);
            // 
            // guncellemeTimer
            // 
            this.guncellemeTimer.Enabled = true;
            this.guncellemeTimer.Interval = 1;
            this.guncellemeTimer.Tick += new System.EventHandler(this.guncellemeTimer_Tick);
            // 
            // bilgiSkor
            // 
            this.bilgiSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiSkor.Location = new System.Drawing.Point(27, 255);
            this.bilgiSkor.Name = "bilgiSkor";
            this.bilgiSkor.Size = new System.Drawing.Size(157, 20);
            this.bilgiSkor.TabIndex = 12;
            this.bilgiSkor.Text = "Skor : 0";
            this.bilgiSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OyunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 681);
            this.Controls.Add(this.oyunAlanPanel);
            this.Controls.Add(this.bilgiPAnel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OyunForm";
            this.Text = "OyunForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OyunForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OyunForm_KeyDown);
            this.bilgiPAnel.ResumeLayout(false);
            this.bilgiPAnel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bilgiPAnel;
        private System.Windows.Forms.Panel oyunAlanPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label bilgiKalan;
        private System.Windows.Forms.Label bilgiyapilan;
        private System.Windows.Forms.Label bilgiSureLabel;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Label bilgiUrunLabel;
        private System.Windows.Forms.Label bilgiAdLabel;
        private System.Windows.Forms.Label marulSayiaLabel;
        private System.Windows.Forms.Label soganSayiLabel;
        private System.Windows.Forms.Label kaseSayiLabel;
        private System.Windows.Forms.Timer gecenSureTimer;
        private System.Windows.Forms.Timer guncellemeTimer;
        private System.Windows.Forms.Label bilgiSkor;
    }
}