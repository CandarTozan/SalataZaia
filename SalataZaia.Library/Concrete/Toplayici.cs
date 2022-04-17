// Geliştirici : Candar TOZAN
// Öğrenci NO : B211200027
// Nesneye Dayalı Programlama 1. Proje / Tasarım

using System.Drawing;

namespace SalataZaia.Library.Abstract
{
    class Toplayici : Cisim
    {
        public Toplayici(int panelGenisligi, int panelYuksekligi, Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            Center = panelGenisligi/2;
            Bottom = panelYuksekligi;
            HareketMesafesi = Width;
        }
    }
}
