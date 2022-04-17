
namespace SalataZaia.Desktop
{
    partial class TusBilgiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TusBilgiForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tusBilgiLAbel = new System.Windows.Forms.Label();
            this.kapatmaButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.kapatmaButton);
            this.panel1.Controls.Add(this.tusBilgiLAbel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 208);
            this.panel1.TabIndex = 0;
            // 
            // tusBilgiLAbel
            // 
            this.tusBilgiLAbel.AutoSize = true;
            this.tusBilgiLAbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tusBilgiLAbel.ForeColor = System.Drawing.Color.Black;
            this.tusBilgiLAbel.Location = new System.Drawing.Point(54, 44);
            this.tusBilgiLAbel.Name = "tusBilgiLAbel";
            this.tusBilgiLAbel.Size = new System.Drawing.Size(442, 60);
            this.tusBilgiLAbel.TabIndex = 1;
            this.tusBilgiLAbel.Text = "Oyunu Durdurmak için P tuşuna basın.\r\nToplayıcıyı sola hareket ettirmek için Sol " +
    "Yön Tuşununa basın.\r\nToplayıcıyı sağa hareket ettirmek için Sağa Yön Tuşunu bası" +
    "n.";
            // 
            // kapatmaButton
            // 
            this.kapatmaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kapatmaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapatmaButton.Location = new System.Drawing.Point(169, 144);
            this.kapatmaButton.Name = "kapatmaButton";
            this.kapatmaButton.Size = new System.Drawing.Size(209, 33);
            this.kapatmaButton.TabIndex = 2;
            this.kapatmaButton.Text = "Kapatmak İçin Tıklayın";
            this.kapatmaButton.UseVisualStyleBackColor = true;
            this.kapatmaButton.Click += new System.EventHandler(this.kapatmaButton_Click);
            // 
            // TusBilgiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(547, 208);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(547, 208);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(547, 208);
            this.Name = "TusBilgiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tuş Bilgisi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tusBilgiLAbel;
        private System.Windows.Forms.Button kapatmaButton;
    }
}