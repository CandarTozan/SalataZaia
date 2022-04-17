using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalataZaia.Desktop
{
    public partial class SkorForm : Form
    {
        public SkorForm()
        {
            InitializeComponent();
            SkorGoster();
        }

        private void cıkısButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SkorGoster()
        { 
            string dosya_you = "SkorBoard.txt";

            skorLabel.Text = null;

            FileStream fs = new FileStream(dosya_you, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string skor = sr.ReadLine();
            for (int i = 0; skor!= null; i++)
            {
                skorLabel.Text += skor + "\n";
                skor = sr.ReadLine();
            }

            sr.Close();
            fs.Close();
        }

    }
}
