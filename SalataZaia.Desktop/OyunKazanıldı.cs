using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalataZaia.Desktop
{
    public partial class OyunKazanıldı : Form
    {
        public OyunKazanıldı(int skor)
        {
            InitializeComponent();

            skorLabel.Text = "Tebrikler Kazandın.\n\nSkorunuz : " + skor;
        }

        private void cıkısButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
