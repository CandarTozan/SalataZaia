// Geliştirici : Candar TOZAN
// Öğrenci NO : B211200027
// Nesneye Dayalı Programlama 1. Proje / Tasarım

//en iyi skorların gözterildiği tablo
using System;
using System.IO;
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

        //tıklandığında formu kapatır
        private void cıkısButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //skor text dosyasından çekilir ve label'ın text'ine yazılır
        private void SkorGoster()
        { 
            string dosya_you = "SkorBoard.txt";

            skorLabel.Text = null;

            FileStream fs = new FileStream(dosya_you, FileMode.OpenOrCreate, FileAccess.Read);
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
