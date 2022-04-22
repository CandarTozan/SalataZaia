
namespace SalataZaia.Desktop
{
    partial class SkorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkorForm));
            this.SkorPanel = new System.Windows.Forms.Panel();
            this.cıkısButton = new System.Windows.Forms.Button();
            this.skorLabel = new System.Windows.Forms.Label();
            this.SkorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SkorPanel
            // 
            this.SkorPanel.BackColor = System.Drawing.Color.LightGreen;
            this.SkorPanel.Controls.Add(this.cıkısButton);
            this.SkorPanel.Controls.Add(this.skorLabel);
            this.SkorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SkorPanel.Location = new System.Drawing.Point(0, 0);
            this.SkorPanel.Name = "SkorPanel";
            this.SkorPanel.Size = new System.Drawing.Size(463, 339);
            this.SkorPanel.TabIndex = 0;
            // 
            // cıkısButton
            // 
            this.cıkısButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cıkısButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cıkısButton.Location = new System.Drawing.Point(164, 277);
            this.cıkısButton.Name = "cıkısButton";
            this.cıkısButton.Size = new System.Drawing.Size(135, 23);
            this.cıkısButton.TabIndex = 1;
            this.cıkısButton.Text = "Çıkış";
            this.cıkısButton.UseVisualStyleBackColor = true;
            this.cıkısButton.Click += new System.EventHandler(this.cıkısButton_Click);
            // 
            // skorLabel
            // 
            this.skorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorLabel.Location = new System.Drawing.Point(12, 33);
            this.skorLabel.Name = "skorLabel";
            this.skorLabel.Size = new System.Drawing.Size(435, 241);
            this.skorLabel.TabIndex = 0;
            this.skorLabel.Text = "0 Skor\r\n0 Skor\r\n0 Skor\r\n0 Skor\r\n0 Skor";
            this.skorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SkorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 339);
            this.Controls.Add(this.SkorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SkorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skor";
            this.SkorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SkorPanel;
        private System.Windows.Forms.Button cıkısButton;
        private System.Windows.Forms.Label skorLabel;
    }
}