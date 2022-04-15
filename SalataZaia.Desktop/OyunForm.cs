using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalataZaia.Library.Concrete;

namespace SalataZaia.Desktop
{
    public partial class OyunForm : Form
    {
        int kalanSure;
        Oyun _oyun;

        public OyunForm(string ad, string Soyad, string urunAd, int urunMiktar, int sure)
        {
            InitializeComponent();

            string _ad = ad;
            string _soyad = Soyad;
            string _urunad = urunAd;
            int _urunMiktar = urunMiktar;
            kalanSure = sure;

            _oyun = new Oyun(oyunAlanPanel);

            bilgiAdLabel.Text = _ad + " " + _soyad;
            bilgiUrunLabel.Text = _urunad;
            bilgiyapilan.Text = "Toplam Yapılan : " + 0;
            bilgiKalan.Text = "Kalan : " + _urunMiktar;
            bilgiSureLabel.Text = sure.ToString();
        }

        private void OyunForm_Load(object sender, EventArgs e)
        {
            _oyun.Baslat();
        }

        private void OyunForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.P:
                    _oyun.DurDevam();
                    break;
                case Keys.Left:
                    _oyun.ToplayiciyiHareketEttir(Library.Enum.Yon.Sola);
                    break;
                case Keys.Right:
                    _oyun.ToplayiciyiHareketEttir(Library.Enum.Yon.Saga);
                    break;
            }
    
        }

        private void gecenSureTimer_Tick(object sender, EventArgs e)
        {
            kalanSure -= 1;
            bilgiSureLabel.Text = kalanSure.ToString();

            if (kalanSure == 0)
            {
                gecenSureTimer.Stop();
                _oyun.Bitir();
            }
        }
    }
}
