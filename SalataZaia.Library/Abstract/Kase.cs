using System;
using System.Drawing;

namespace SalataZaia.Library.Abstract
{
    class Kase : Cisim
    {

        private static readonly Random Random = new Random();

        public Kase(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {

            HareketMesafesi = (int)(Height * 0.1);
            Left = Random.Next(hareketAlaniBoyutlari.Width - Width + 1);

        }
    }
}
