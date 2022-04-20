// Geliştirici : Candar TOZAN
// Öğrenci NO : B211200027
// Nesneye Dayalı Programlama 1. Proje / Tasarım

using System;
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
            //oyun esnasında basılan tuşa göre gerekli olan eylemi yapar
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

        //kalan süreyi ayarlar
        private void gecenSureTimer_Tick(object sender, EventArgs e)
        {
            kalanSure -= 1;
            bilgiSureLabel.Text = kalanSure.ToString();

            //zamana bittiğinde oyunu bitirir
            if (kalanSure <= 0)
            {
                gecenSureTimer.Stop();
                _oyun.Bitir();
                OyunBitti oyunBitti = new OyunBitti();
                oyunBitti.ShowDialog();
                Close();
            }
        }

        //anlık verileri günceller
        private void guncellemeTimer_Tick(object sender, EventArgs e)
        {
            marulSayiaLabel.Text = _oyun._marulSayisi.ToString();
            soganSayiLabel.Text = _oyun._soganSayisi.ToString();
            kaseSayiLabel.Text = _oyun._kaseSayisi.ToString();
            bilgiKalan.Text = "Kalan : " + (_oyun._istenenUrunMiktar - _oyun._mevcutUrunMiktar).ToString();
            bilgiyapilan.Text = "Toplam Yapılan : " + _oyun._mevcutUrunMiktar.ToString();
            _skor = _oyun.skor;
            bilgiSkor.Text = "Skor : " + _skor;

            //yeterli sayıda ürün yapılsıysa oyunu bitirir ve oyun kazıldı formunu açar
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

        //oyundan gelen skorla skor tablosunu dosya okuma ve yazma ile gerekirse günceller
        private void SkorGuncelle(int skor,string ad)
        {
            string[] skorDizi = new string[5];

            string[] yeniSkor = { skor.ToString(), ad };

            string dosya_you = "SkorBoard.txt";

            FileStream fs = new FileStream(dosya_you, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string yazi = sr.ReadLine();
            //veriler diziye alınır
            for (int i = 0; yazi != null; i++)
            {
                skorDizi[i] = yazi;
                yazi = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

            //yeni skor en yüksek skorlarla karşılatırılır vr gerekirse yer değiştirilir
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

            //dizideki skorlar dosayaya aktarılır
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
