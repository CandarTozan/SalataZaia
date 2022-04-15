
namespace SalataZaia.Desktop
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.sloganPanel = new System.Windows.Forms.Panel();
            this.sloganLabel = new System.Windows.Forms.Label();
            this.girisBilgiLabel = new System.Windows.Forms.Label();
            this.tusBilgiPanel = new System.Windows.Forms.Label();
            this.skorBilgiPanel = new System.Windows.Forms.Label();
            this.baslatPct = new System.Windows.Forms.PictureBox();
            this.yonPct = new System.Windows.Forms.PictureBox();
            this.siralamaPct = new System.Windows.Forms.PictureBox();
            this.anaMenuPanel = new System.Windows.Forms.Panel();
            this.musteriBilgiPanel = new System.Windows.Forms.Panel();
            this.baslatButton = new System.Windows.Forms.Button();
            this.suretxt = new System.Windows.Forms.TextBox();
            this.miktartxt = new System.Windows.Forms.TextBox();
            this.uruntxt = new System.Windows.Forms.TextBox();
            this.soyadtxt = new System.Windows.Forms.TextBox();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.sureBelirlenenLabel = new System.Windows.Forms.Label();
            this.urunMiktarLabel = new System.Windows.Forms.Label();
            this.talepEdileUrunLabel = new System.Windows.Forms.Label();
            this.musteriSoyadLabel = new System.Windows.Forms.Label();
            this.musteriAdLabel = new System.Windows.Forms.Label();
            this.sloganPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baslatPct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yonPct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siralamaPct)).BeginInit();
            this.anaMenuPanel.SuspendLayout();
            this.musteriBilgiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sloganPanel
            // 
            this.sloganPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.sloganPanel.Controls.Add(this.sloganLabel);
            this.sloganPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sloganPanel.Location = new System.Drawing.Point(0, 0);
            this.sloganPanel.Name = "sloganPanel";
            this.sloganPanel.Size = new System.Drawing.Size(622, 44);
            this.sloganPanel.TabIndex = 0;
            // 
            // sloganLabel
            // 
            this.sloganLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sloganLabel.ForeColor = System.Drawing.Color.White;
            this.sloganLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sloganLabel.Location = new System.Drawing.Point(133, 13);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(371, 25);
            this.sloganLabel.TabIndex = 0;
            this.sloganLabel.Text = "SalataZaia - Dünyanın En İyi Salatası";
            this.sloganLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // girisBilgiLabel
            // 
            this.girisBilgiLabel.AutoSize = true;
            this.girisBilgiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisBilgiLabel.ForeColor = System.Drawing.Color.White;
            this.girisBilgiLabel.Location = new System.Drawing.Point(122, 35);
            this.girisBilgiLabel.Name = "girisBilgiLabel";
            this.girisBilgiLabel.Size = new System.Drawing.Size(467, 20);
            this.girisBilgiLabel.TabIndex = 1;
            this.girisBilgiLabel.Text = "Oyuna başlamak İçin bilgilerinizi girin ve BAŞLAT butonuna basın.\r\n";
            // 
            // tusBilgiPanel
            // 
            this.tusBilgiPanel.AutoSize = true;
            this.tusBilgiPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tusBilgiPanel.ForeColor = System.Drawing.Color.White;
            this.tusBilgiPanel.Location = new System.Drawing.Point(122, 105);
            this.tusBilgiPanel.Name = "tusBilgiPanel";
            this.tusBilgiPanel.Size = new System.Drawing.Size(252, 20);
            this.tusBilgiPanel.TabIndex = 2;
            this.tusBilgiPanel.Text = "Oyun tuş takımı bilgisi için tıklayınız.";
            // 
            // skorBilgiPanel
            // 
            this.skorBilgiPanel.AutoSize = true;
            this.skorBilgiPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorBilgiPanel.ForeColor = System.Drawing.Color.White;
            this.skorBilgiPanel.Location = new System.Drawing.Point(122, 178);
            this.skorBilgiPanel.Name = "skorBilgiPanel";
            this.skorBilgiPanel.Size = new System.Drawing.Size(294, 20);
            this.skorBilgiPanel.TabIndex = 3;
            this.skorBilgiPanel.Text = "En iyi skorları görüntelemek için tıklayınız.";
            // 
            // baslatPct
            // 
            this.baslatPct.Image = ((System.Drawing.Image)(resources.GetObject("baslatPct.Image")));
            this.baslatPct.Location = new System.Drawing.Point(43, 14);
            this.baslatPct.Name = "baslatPct";
            this.baslatPct.Size = new System.Drawing.Size(64, 64);
            this.baslatPct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.baslatPct.TabIndex = 4;
            this.baslatPct.TabStop = false;
            // 
            // yonPct
            // 
            this.yonPct.Image = ((System.Drawing.Image)(resources.GetObject("yonPct.Image")));
            this.yonPct.Location = new System.Drawing.Point(43, 84);
            this.yonPct.Name = "yonPct";
            this.yonPct.Size = new System.Drawing.Size(64, 64);
            this.yonPct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.yonPct.TabIndex = 5;
            this.yonPct.TabStop = false;
            // 
            // siralamaPct
            // 
            this.siralamaPct.Image = ((System.Drawing.Image)(resources.GetObject("siralamaPct.Image")));
            this.siralamaPct.Location = new System.Drawing.Point(43, 154);
            this.siralamaPct.Name = "siralamaPct";
            this.siralamaPct.Size = new System.Drawing.Size(64, 64);
            this.siralamaPct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.siralamaPct.TabIndex = 6;
            this.siralamaPct.TabStop = false;
            // 
            // anaMenuPanel
            // 
            this.anaMenuPanel.Controls.Add(this.musteriBilgiPanel);
            this.anaMenuPanel.Controls.Add(this.tusBilgiPanel);
            this.anaMenuPanel.Controls.Add(this.siralamaPct);
            this.anaMenuPanel.Controls.Add(this.girisBilgiLabel);
            this.anaMenuPanel.Controls.Add(this.yonPct);
            this.anaMenuPanel.Controls.Add(this.skorBilgiPanel);
            this.anaMenuPanel.Controls.Add(this.baslatPct);
            this.anaMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anaMenuPanel.Location = new System.Drawing.Point(0, 44);
            this.anaMenuPanel.Name = "anaMenuPanel";
            this.anaMenuPanel.Size = new System.Drawing.Size(622, 461);
            this.anaMenuPanel.TabIndex = 7;
            // 
            // musteriBilgiPanel
            // 
            this.musteriBilgiPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.musteriBilgiPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.musteriBilgiPanel.Controls.Add(this.baslatButton);
            this.musteriBilgiPanel.Controls.Add(this.suretxt);
            this.musteriBilgiPanel.Controls.Add(this.miktartxt);
            this.musteriBilgiPanel.Controls.Add(this.uruntxt);
            this.musteriBilgiPanel.Controls.Add(this.soyadtxt);
            this.musteriBilgiPanel.Controls.Add(this.adtxt);
            this.musteriBilgiPanel.Controls.Add(this.sureBelirlenenLabel);
            this.musteriBilgiPanel.Controls.Add(this.urunMiktarLabel);
            this.musteriBilgiPanel.Controls.Add(this.talepEdileUrunLabel);
            this.musteriBilgiPanel.Controls.Add(this.musteriSoyadLabel);
            this.musteriBilgiPanel.Controls.Add(this.musteriAdLabel);
            this.musteriBilgiPanel.Location = new System.Drawing.Point(126, 243);
            this.musteriBilgiPanel.Name = "musteriBilgiPanel";
            this.musteriBilgiPanel.Size = new System.Drawing.Size(375, 206);
            this.musteriBilgiPanel.TabIndex = 7;
            // 
            // baslatButton
            // 
            this.baslatButton.BackColor = System.Drawing.Color.LightGreen;
            this.baslatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslatButton.Location = new System.Drawing.Point(18, 161);
            this.baslatButton.Name = "baslatButton";
            this.baslatButton.Size = new System.Drawing.Size(330, 30);
            this.baslatButton.TabIndex = 10;
            this.baslatButton.Text = "Başlat";
            this.baslatButton.UseVisualStyleBackColor = false;
            this.baslatButton.Click += new System.EventHandler(this.baslatButton_Click);
            // 
            // suretxt
            // 
            this.suretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.suretxt.Location = new System.Drawing.Point(215, 130);
            this.suretxt.Name = "suretxt";
            this.suretxt.Size = new System.Drawing.Size(133, 26);
            this.suretxt.TabIndex = 9;
            // 
            // miktartxt
            // 
            this.miktartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktartxt.Location = new System.Drawing.Point(215, 102);
            this.miktartxt.Name = "miktartxt";
            this.miktartxt.Size = new System.Drawing.Size(133, 26);
            this.miktartxt.TabIndex = 8;
            // 
            // uruntxt
            // 
            this.uruntxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uruntxt.Location = new System.Drawing.Point(215, 74);
            this.uruntxt.Name = "uruntxt";
            this.uruntxt.Size = new System.Drawing.Size(133, 26);
            this.uruntxt.TabIndex = 7;
            // 
            // soyadtxt
            // 
            this.soyadtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadtxt.Location = new System.Drawing.Point(215, 46);
            this.soyadtxt.Name = "soyadtxt";
            this.soyadtxt.Size = new System.Drawing.Size(133, 26);
            this.soyadtxt.TabIndex = 6;
            // 
            // adtxt
            // 
            this.adtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adtxt.Location = new System.Drawing.Point(215, 18);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(133, 26);
            this.adtxt.TabIndex = 5;
            // 
            // sureBelirlenenLabel
            // 
            this.sureBelirlenenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.sureBelirlenenLabel.ForeColor = System.Drawing.Color.White;
            this.sureBelirlenenLabel.Location = new System.Drawing.Point(14, 130);
            this.sureBelirlenenLabel.Name = "sureBelirlenenLabel";
            this.sureBelirlenenLabel.Size = new System.Drawing.Size(183, 28);
            this.sureBelirlenenLabel.TabIndex = 4;
            this.sureBelirlenenLabel.Text = "Süre (sn)                   :";
            // 
            // urunMiktarLabel
            // 
            this.urunMiktarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.urunMiktarLabel.ForeColor = System.Drawing.Color.White;
            this.urunMiktarLabel.Location = new System.Drawing.Point(14, 102);
            this.urunMiktarLabel.Name = "urunMiktarLabel";
            this.urunMiktarLabel.Size = new System.Drawing.Size(183, 28);
            this.urunMiktarLabel.TabIndex = 3;
            this.urunMiktarLabel.Text = "Ürün Miktarı              :";
            // 
            // talepEdileUrunLabel
            // 
            this.talepEdileUrunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.talepEdileUrunLabel.ForeColor = System.Drawing.Color.White;
            this.talepEdileUrunLabel.Location = new System.Drawing.Point(14, 74);
            this.talepEdileUrunLabel.Name = "talepEdileUrunLabel";
            this.talepEdileUrunLabel.Size = new System.Drawing.Size(183, 28);
            this.talepEdileUrunLabel.TabIndex = 2;
            this.talepEdileUrunLabel.Text = "Talep Edilen Ürün     :";
            // 
            // musteriSoyadLabel
            // 
            this.musteriSoyadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.musteriSoyadLabel.ForeColor = System.Drawing.Color.White;
            this.musteriSoyadLabel.Location = new System.Drawing.Point(14, 46);
            this.musteriSoyadLabel.Name = "musteriSoyadLabel";
            this.musteriSoyadLabel.Size = new System.Drawing.Size(183, 28);
            this.musteriSoyadLabel.TabIndex = 1;
            this.musteriSoyadLabel.Text = "Müşteri Soyadı          : ";
            // 
            // musteriAdLabel
            // 
            this.musteriAdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.musteriAdLabel.ForeColor = System.Drawing.Color.White;
            this.musteriAdLabel.Location = new System.Drawing.Point(14, 18);
            this.musteriAdLabel.Name = "musteriAdLabel";
            this.musteriAdLabel.Size = new System.Drawing.Size(183, 28);
            this.musteriAdLabel.TabIndex = 0;
            this.musteriAdLabel.Text = "Müşteri Adı               :";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(622, 505);
            this.Controls.Add(this.anaMenuPanel);
            this.Controls.Add(this.sloganPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(638, 544);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(638, 544);
            this.Name = "MenuForm";
            this.Text = "SalataZaia";
            this.sloganPanel.ResumeLayout(false);
            this.sloganPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baslatPct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yonPct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siralamaPct)).EndInit();
            this.anaMenuPanel.ResumeLayout(false);
            this.anaMenuPanel.PerformLayout();
            this.musteriBilgiPanel.ResumeLayout(false);
            this.musteriBilgiPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sloganPanel;
        private System.Windows.Forms.Label sloganLabel;
        private System.Windows.Forms.Label girisBilgiLabel;
        private System.Windows.Forms.Label tusBilgiPanel;
        private System.Windows.Forms.Label skorBilgiPanel;
        private System.Windows.Forms.PictureBox baslatPct;
        private System.Windows.Forms.PictureBox yonPct;
        private System.Windows.Forms.PictureBox siralamaPct;
        private System.Windows.Forms.Panel anaMenuPanel;
        private System.Windows.Forms.Panel musteriBilgiPanel;
        private System.Windows.Forms.Label sureBelirlenenLabel;
        private System.Windows.Forms.Label urunMiktarLabel;
        private System.Windows.Forms.Label talepEdileUrunLabel;
        private System.Windows.Forms.Label musteriSoyadLabel;
        private System.Windows.Forms.Label musteriAdLabel;
        private System.Windows.Forms.TextBox suretxt;
        private System.Windows.Forms.TextBox miktartxt;
        private System.Windows.Forms.TextBox uruntxt;
        private System.Windows.Forms.TextBox soyadtxt;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.Button baslatButton;
    }
}

