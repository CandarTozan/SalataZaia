// Geliştirici : Candar TOZAN
// Öğrenci NO : B211200027
// Nesneye Dayalı Programlama 1. Proje / Tasarım

using System;
using System.Windows.Forms;

namespace SalataZaia.Desktop
{
    public partial class MenuForm : Form
    {

        OyunForm oyunForm;
        TusBilgiForm tusBilgiForm;
        SkorForm skorForm;

        public MenuForm()
        {
            InitializeComponent();
        }
        
        private void baslatButton_Click(object sender, EventArgs e)
        {
            if (!DolduMu()) return;
            else
            {
                int sure = Convert.ToInt32(suretxt.Text);
                oyunForm = new OyunForm(adtxt.Text, soyadtxt.Text, uruntxt.Text,
                Convert.ToInt32(miktartxt.Text), sure);
                oyunForm.ShowDialog();
            }
        }

        //Tüm bilgilerin girilip girilmediğini kontrol eden fonksiyon
        private bool DolduMu()
        {
            if (String.IsNullOrEmpty(adtxt.Text) || String.IsNullOrEmpty(soyadtxt.Text)
                || String.IsNullOrEmpty(uruntxt.Text) || String.IsNullOrEmpty(miktartxt.Text)
                || String.IsNullOrEmpty(suretxt.Text)) return false;

            return true;
        }

        //miktara sadece sayı girilmesi sağlayan fonksiyon
        private void miktartxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //süreye sadece sayı girilmesi sağlayan fonksiyon
        private void suretxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //tuş ve oyun bilgi ekranını açan fonkisyon
        private void tusBilgiPanel_Click(object sender, EventArgs e)
        {
            tusBilgiForm = new TusBilgiForm();
            tusBilgiForm.ShowDialog();
        }

        //skor tablosunu açan fonksiyon
        private void skorBilgiPanel_Click(object sender, EventArgs e)
        {
            skorForm = new SkorForm();
            skorForm.ShowDialog();
        }
    }
}
