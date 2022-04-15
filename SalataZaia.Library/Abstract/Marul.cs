using System;
using System.Drawing;

namespace SalataZaia.Library.Abstract
{
    internal class Marul : Cisim
    {

        private static readonly Random Random = new Random();

        public Marul(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {

            HareketMesafesi = (int)(Height * 0.1);
            Left = Random.Next(hareketAlaniBoyutlari.Width - Width + 1);

        }
    }
}
