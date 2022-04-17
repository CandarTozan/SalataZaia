using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SalataZaia.Library.Abstract;
using SalataZaia.Library.Enum;
using SalataZaia.Library.Interface;

namespace SalataZaia.Library.Concrete
{
    public class Oyun : IOyun
    {
        #region Alanlar

        private readonly Panel _oyunAlaniPanel;
        private Toplayici _toplayici;
        private Timer _dropOlusturmaTimer = new Timer { Interval = 1000 };
        private Timer _hareketEtmeTimer = new Timer { Interval = 100 };
        private Timer _gizemliKutuTimer = new Timer { Interval = 10000 };  //Her Gizemli Kutu oluştuğunda oyun dropların düşme hızı artıyor.
        private Timer _guncellemeTimer = new Timer { Interval = 100 };
        private readonly List<Marul> _marullar = new List<Marul>();
        private readonly List<Sogan> _soganlar = new List<Sogan>();
        private readonly List<Kase> _kaseler = new List<Kase>();
        private readonly List<GizemliKutu> _gizemliKutular = new List<GizemliKutu>();
        private static readonly Random _random = new Random();
        

        #endregion

        #region Özellikler

        public bool DevamEdiyorMu { get; private set; }
        public int _marulSayisi { get; private set; }
        public int _soganSayisi { get; private set; }
        public int _kaseSayisi { get; private set; }
        public int _mevcutUrunMiktar { get; private set; }
        public int _istenenUrunMiktar { get; private set; }
        public int skor { get; private set; }
        private int _oyunHizi { get; set; }

        #endregion

        #region Metotlar

        public Oyun(Panel oyunAlaniPanel, int istenilenUrunMiktar)
        {
            _oyunAlaniPanel = oyunAlaniPanel;
            _istenenUrunMiktar = istenilenUrunMiktar;
            _oyunHizi = 100;
            _dropOlusturmaTimer.Tick += DropOlusturmaTimer_Tick;
            _hareketEtmeTimer.Tick += HareketEtmeTimer_Tick;
            _gizemliKutuTimer.Tick += GizemLiKutuTimer_Tick;
            _guncellemeTimer.Tick += GuncellemeTimer_Tick;
        }

        private void GuncellemeTimer_Tick(object sender, EventArgs e)
        {
            if (_marulSayisi >= 3 && _soganSayisi >= 2 && _kaseSayisi >= 1)
            {
                _marulSayisi -= 3;
                _soganSayisi -= 2;
                _kaseSayisi -= 1;
                _mevcutUrunMiktar++;
            }
        }

        private void GizemLiKutuTimer_Tick(object sender, EventArgs e)
        {
            GizemliKutuOlustur();
            OyunuHizlandir();
        }

        private void OyunuHizlandir()
        {
            if (_oyunHizi > 10)
            {
                _oyunHizi -= 10;
                _hareketEtmeTimer.Interval = _oyunHizi;
            }
        }

        private void GizemliKutuOlustur()
        {
            var gizemliKutu = new GizemliKutu(_oyunAlaniPanel.Size);
            _gizemliKutular.Add(gizemliKutu);
            _oyunAlaniPanel.Controls.Add(gizemliKutu);

        }

        private void HareketEtmeTimer_Tick(object sender, EventArgs e)
        {
            DroplariHareketEttir();
        }

        private void DroplariHareketEttir()  //Dropları hareket ettiriyor, toplanma ve çarpma durumuna göre değişiklik yapıyor
        {
            for (int i = _marullar.Count - 1; i >= 0; i--)
            {
                var marul = _marullar[i];
                var carptiMİ = marul.HareketEttir(Yon.Asagi);
                if (marul.ToplanildiMi(_toplayici))
                {
                    _marulSayisi++;
                    _marullar.Remove(marul);
                    _oyunAlaniPanel.Controls.Remove(marul);
                    skor += 10;
                }
                if (carptiMİ)
                {
                    _marullar.Remove(marul);
                    _oyunAlaniPanel.Controls.Remove(marul);
                }
            }

            for (int i = _soganlar.Count - 1; i >= 0; i--)
            {
                var sogan = _soganlar[i];
                var carptiMİ = sogan.HareketEttir(Yon.Asagi);
                if (sogan.ToplanildiMi(_toplayici))
                {
                    _soganSayisi++;
                    _soganlar.Remove(sogan);
                    _oyunAlaniPanel.Controls.Remove(sogan);
                    skor += 10;
                }
                if (carptiMİ)
                {
                    _soganlar.Remove(sogan);
                    _oyunAlaniPanel.Controls.Remove(sogan);
                }
            }

            for (int i = _kaseler.Count - 1; i >= 0; i--)
            {
                var kase= _kaseler[i];
                var carptiMİ = kase.HareketEttir(Yon.Asagi);
                if (kase.ToplanildiMi(_toplayici))
                {
                    _kaseSayisi++;
                    _kaseler.Remove(kase);
                    _oyunAlaniPanel.Controls.Remove(kase);
                    skor += 10;
                }
                if (carptiMİ)
                {
                    _kaseler.Remove(kase);
                    _oyunAlaniPanel.Controls.Remove(kase);
                }
            }

            for (int i = _gizemliKutular.Count - 1; i >= 0; i--)
            {
                var gizemliKutu = _gizemliKutular[i];
                var carptiMİ = gizemliKutu.HareketEttir(Yon.Asagi);
                if (gizemliKutu.ToplanildiMi(_toplayici))
                {
                    int secim = _random.Next(2);
                    if (secim == 0)
                    {
                        _marulSayisi += 5;
                        _soganSayisi += 5;
                        _kaseSayisi += 5;
                        _gizemliKutular.Remove(gizemliKutu);
                        _oyunAlaniPanel.Controls.Remove(gizemliKutu);
                        skor += 500;
                    }
                    else if (secim == 1)
                    {
                        _marulSayisi -= 5;
                        _soganSayisi -= 5;
                        _kaseSayisi -= 5;
                        _gizemliKutular.Remove(gizemliKutu);
                        _oyunAlaniPanel.Controls.Remove(gizemliKutu);
                        skor -= 500;
                    }
                }
                if (carptiMİ)
                {
                    _gizemliKutular.Remove(gizemliKutu);
                    _oyunAlaniPanel.Controls.Remove(gizemliKutu);
                }
            }
        }

        private void DropOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            DropOlustur();
        }

        private static readonly Random droprandom = new Random();  //Rasgele oluşturulacak drop seçimi için sayi üretecek random

        private void DropOlustur()
        {
            int secim = droprandom.Next(3);
            if (secim==0) 
            {
                var marul = new Marul(_oyunAlaniPanel.Size);
                _marullar.Add(marul);
                _oyunAlaniPanel.Controls.Add(marul);
            }
            else if (secim == 1)
            {
                var sogan = new Sogan(_oyunAlaniPanel.Size);
                _soganlar.Add(sogan);
                _oyunAlaniPanel.Controls.Add(sogan);
            }
            else if (secim == 2)
            {
                var kase = new Kase(_oyunAlaniPanel.Size);
                _kaseler.Add(kase);
                _oyunAlaniPanel.Controls.Add(kase);
            }

            
        }

        public void Baslat()
        {
            if (DevamEdiyorMu) return;

            DevamEdiyorMu = true;
            ZamanalayicilariBaslat();

            ToplayiciOlustur();
        }

        private void ToplayiciOlustur()
        {
            _toplayici = new Toplayici(_oyunAlaniPanel.Width, _oyunAlaniPanel.Height, 
                _oyunAlaniPanel.Size);
            _oyunAlaniPanel.Controls.Add(_toplayici);
        }

        private void ZamanalayicilariBaslat()
        {
            _dropOlusturmaTimer.Start();
            _hareketEtmeTimer.Start();
            _gizemliKutuTimer.Start();
            _guncellemeTimer.Start();
        }

        public void DurDevam()
        {
            if (DevamEdiyorMu)
            {
                ZamanalayicilariDurdur();
                DevamEdiyorMu = false;
            }
            else if (!DevamEdiyorMu)
            {
                ZamanalayicilariBaslat();
                DevamEdiyorMu = true;
            }
        }

        public void Bitir()
        {
            if (!DevamEdiyorMu) return;

            DevamEdiyorMu = false;
            ZamanalayicilariDurdur();
        }

        private void ZamanalayicilariDurdur()
        {
            _dropOlusturmaTimer.Stop();
            _hareketEtmeTimer.Stop();
            _gizemliKutuTimer.Stop();
            _guncellemeTimer.Stop();
        }

        public void ToplayiciyiHareketEttir(Yon yon)
        {
            if (!DevamEdiyorMu) return;

            _toplayici.HareketEttir(yon);
        }

        #endregion

    }
}
