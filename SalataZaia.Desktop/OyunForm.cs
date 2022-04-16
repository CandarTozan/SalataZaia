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
        string _ad;
        string _soyad;
        string _urunad;
        int _urunIstenilenMiktar;
        int _skor;

        public OyunForm(string ad, string Soyad, string urunAd, int urunIstenilenMiktar, int sure)
        {
            InitializeComponent();

            _ad = ad;
            _soyad = Soyad;
            _urunad = urunAd;
            _urunIstenilenMiktar = urunIstenilenMiktar;
            kalanSure = sure;

            _oyun = new Oyun(oyunAlanPanel,urunIstenilenMiktar);

            bilgiAdLabel.Text = _ad + " " + _soyad;
            bilgiUrunLabel.Text = _urunad;
            bilgiyapilan.Text = "Toplam Yapılan : " + 0;
            bilgiKalan.Text = "Kalan : " + _urunIstenilenMiktar;
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
                    {
                        _oyun.DurDevam();
                        if (!_oyun.DevamEdiyorMu) gecenSureTimer.Stop();
                        else
                            gecenSureTimer.Start();
                    }
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

            if (kalanSure <= 0)
            {
                gecenSureTimer.Stop();
                _oyun.Bitir();
                MessageBox.Show("ZAMANIN BİTTİĞİ İÇİN OYUN BİTTİ :[","OYUN BİTTİ");
                Close();
            }
        }

        private void guncellemeTimer_Tick(object sender, EventArgs e)
        {
            marulSayiaLabel.Text = _oyun._marulSayisi.ToString();
            soganSayiLabel.Text = _oyun._soganSayisi.ToString();
            kaseSayiLabel.Text = _oyun._kaseSayisi.ToString();
            bilgiKalan.Text = "Kalan : " + (_oyun._istenenUrunMiktar - _oyun._mevcutUrunMiktar).ToString();
            bilgiyapilan.Text = "Toplam Yapılan : " + _oyun._mevcutUrunMiktar.ToString();

            if (_oyun._mevcutUrunMiktar == _urunIstenilenMiktar)
            {
                gecenSureTimer.Stop();
                guncellemeTimer.Stop();
                _skor = _oyun.skor;
                _oyun.Bitir();
                MessageBox.Show(_skor.ToString(), "SKORUNUZ");
                Close();
            }
        }
    }
}
