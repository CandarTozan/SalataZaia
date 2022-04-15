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

        #endregion

        #region Özellikler

        public bool DevamEdiyorMu { get; private set; }

        #endregion

        #region Metotlar

        public Oyun(Panel oyunAlaniPanel)
        {
            _oyunAlaniPanel = oyunAlaniPanel;
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

        }

        public void ToplayiciyiHareketEttir(Yon yon)
        {
            if (!DevamEdiyorMu) return;

            _toplayici.HareketEttir(yon);
        }

        #endregion

    }
}
