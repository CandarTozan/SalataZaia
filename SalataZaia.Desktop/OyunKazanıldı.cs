// Geliştirici : Candar TOZAN
// Öğrenci NO : B211200027
// Nesneye Dayalı Programlama 1. Proje / Tasarım

//gerekli ürün üretildiğinde ekrana gelip skoru gösteren form
using System;
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
