using System;
using System.Drawing;

namespace SalataZaia.Library.Abstract
{
    internal class Sogan : Cisim
    {

        private static readonly Random Random = new Random(); 

        public Sogan(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {

            HareketMesafesi = (int)(Height * 0.1);
            Left = Random.Next(hareketAlaniBoyutlari.Width - Width + 1);

        }
    }
}
