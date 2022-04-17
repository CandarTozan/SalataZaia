
namespace SalataZaia.Desktop
{
    partial class OyunKazanıldı
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cıkısButton = new System.Windows.Forms.Button();
            this.skorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.cıkısButton);
            this.panel1.Controls.Add(this.skorLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 161);
            this.panel1.TabIndex = 0;
            // 
            // cıkısButton
            // 
            this.cıkısButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cıkısButton.Location = new System.Drawing.Point(190, 110);
            this.cıkısButton.Name = "cıkısButton";
            this.cıkısButton.Size = new System.Drawing.Size(135, 23);
            this.cıkısButton.TabIndex = 3;
            this.cıkısButton.Text = "Çıkış";
            this.cıkısButton.UseVisualStyleBackColor = true;
            this.cıkısButton.Click += new System.EventHandler(this.cıkısButton_Click);
            // 
            // skorLabel
            // 
            this.skorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorLabel.Location = new System.Drawing.Point(69, 28);
            this.skorLabel.Name = "skorLabel";
            this.skorLabel.Size = new System.Drawing.Size(378, 79);
            this.skorLabel.TabIndex = 0;
            this.skorLabel.Text = "Tebrikler Kazandın.\r\n\r\nSkorunuz : 0";
            this.skorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OyunKazanıldı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 161);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OyunKazanıldı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OyunKazanıldı";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label skorLabel;
        private System.Windows.Forms.Button cıkısButton;
    }
}