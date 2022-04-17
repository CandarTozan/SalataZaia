// Geliştirici : Candar TOZAN
// Öğrenci NO : B211200027
// Nesneye Dayalı Programlama 1. Proje / Tasarım

//tuş ve oyun bilgisinin bulunduğu form
using System;
using System.Windows.Forms;

namespace SalataZaia.Desktop
{
    public partial class TusBilgiForm : Form
    {
        public TusBilgiForm()
        {
            InitializeComponent();
        }

        private void kapatmaButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
