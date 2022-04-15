using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
