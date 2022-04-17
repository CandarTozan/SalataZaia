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
using System.IO;

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
                OyunBitti oyunBitti = new OyunBitti();
                oyunBitti.ShowDialog();
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
            _skor = _oyun.skor;
            bilgiSkor.Text = "Skor : " + _skor;

            if (_oyun._mevcutUrunMiktar == _urunIstenilenMiktar)
            {
                gecenSureTimer.Stop();
                guncellemeTimer.Stop();
                _skor = _oyun.skor;
                SkorGuncelle(_skor, _ad);
                _oyun.Bitir();
                OyunKazanıldı oyunKazanıldı = new OyunKazanıldı(_skor);
                oyunKazanıldı.ShowDialog();
                Close();
            }
        }

        private void SkorGuncelle(int skor,string ad)
        {
            string[] skorDizi = new string[5];

            string[] yeniSkor = { skor.ToString(), ad };

            string dosya_you = "SkorBoard.txt";

            FileStream fs = new FileStream(dosya_you, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string yazi = sr.ReadLine();
            for (int i = 0; yazi != null; i++)
            {
                skorDizi[i] = yazi;
                yazi = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

            for (int i = 0; i < skorDizi.Length; i++)
            {
                string[] tutucu = skorDizi[i].Split(' ');
                if (Convert.ToInt32(yeniSkor[0]) > Convert.ToInt32(tutucu[0]))
                {

                    skorDizi[i] = yeniSkor[0] + " " + yeniSkor[1];
                    yeniSkor = tutucu;
                }

            }

            FileStream fs1 = new FileStream(dosya_you, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);

            for (int i = 0; i < skorDizi.Length; i++)
            {
                if (i == skorDizi.Length - 1)
                {
                    sw.Write(skorDizi[i]);
                }
                else
                {
                    sw.WriteLine(skorDizi[i]);
                }

            }

            sw.Flush();
            sw.Close();
            fs1.Close();
        }
    }
}
