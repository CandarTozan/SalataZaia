using System;
using SalataZaia.Library.Enum;
using SalataZaia.Library.Interface;
using System.Windows.Forms;

namespace SalataZaia.Library.Concrete
{
    public class Oyun : IOyun
    {

        #region Alanlar

        private Timer _gecenSureTimer = new Timer { Interval = 1000 };
        private TimeSpan _gecenSure;

        #endregion

        #region Olaylar

        public event EventHandler GecenSureDegisti;

        #endregion

        #region özellikler

        public bool DevamEdiyorMu { get; private set; }

        public TimeSpan GecenSure
        {
            get => _gecenSure;

            private set
            {
                _gecenSure = value;

                GecenSureDegisti?.Invoke(this, EventArgs.Empty);
            }
        }

        #endregion

        #region Metotlar

        public Oyun()
        {

        }

        public void Baslat()
        {
            if (DevamEdiyorMu) return;


            DevamEdiyorMu = true;
        }

        public void Bitir()
        {
            if (!DevamEdiyorMu) return;

            DevamEdiyorMu = false;
        }

        public void Durdur()
        {
        }

        public void ToplayiciyiHareketEttir(Yon yon)
        {
            throw new NotImplementedException();
        }

        #endregion


    }
}
