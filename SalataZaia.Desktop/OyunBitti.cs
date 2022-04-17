// Geliştirici : Candar TOZAN
// Öğrenci NO : B211200027
// Nesneye Dayalı Programlama 1. Proje / Tasarım

//süre bittiğinde ekrana gelen form
using System;
using System.Windows.Forms;

namespace SalataZaia.Desktop
{
    public partial class OyunBitti : Form
    {
        public OyunBitti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cıkısButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
