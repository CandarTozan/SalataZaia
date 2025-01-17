﻿// Geliştirici : Candar TOZAN
// Öğrenci NO : B211200027
// Nesneye Dayalı Programlama 1. Proje / Tasarım

using System;
using System.Drawing;
using System.Windows.Forms;
using SalataZaia.Library.Enum;
using SalataZaia.Library.Interface;

namespace SalataZaia.Library.Abstract
{
    internal class Cisim : PictureBox, IHareketEden
    {
        public Size HareketAlaniBoyutlari { get; }

        public int HareketMesafesi { get; protected set; }

        //değerler daha kolay ulaşmamızı ve değiştirmemizi sağlar
        public new int Right
        {
            get => base.Right;
            set => Left = value - Width;
        }

        public new int Bottom
        {
            get => base.Bottom;
            set => Top = value - Height;
        }

        public int Center
        {
            get => Left + Width / 2;
            set => Left = value - Width / 2;
        }

        public int Middle
        {
            get => Top + Height / 2;
            set => Top = value - Height / 2;
        }

        protected Cisim(Size hareketAlaniBoyutlari)
        {
            Image = Image.FromFile($@"Gorseller\{GetType().Name}.png");
            HareketAlaniBoyutlari = hareketAlaniBoyutlari;
            SizeMode = PictureBoxSizeMode.AutoSize;
        }

        //verilen yöne göre gerekli hareket fonksiyonunu çağırır
        public bool HareketEttir(Yon yon)
        {
            switch (yon)
            {
                case Yon.Yukari:
                    return YukariHareketEttir();
                case Yon.Saga:
                    return SagaHareketEttir();
                case Yon.Asagi:
                    return AsagiHareketEttir();
                case Yon.Sola:
                    return SolaHareketettir();
                default:
                    throw new ArgumentOutOfRangeException(nameof(yon), yon, null);
            }
        }

        private bool SolaHareketettir()
        {
            if (Left == 0) return true;

            var yeniLeft = Left - HareketMesafesi;
            var tasacakMi = yeniLeft < 0;
            Left = tasacakMi ? 0 : yeniLeft;

            return Left == 0;
        }

        private bool AsagiHareketEttir()
        {
            if (Bottom == HareketAlaniBoyutlari.Width) return true;

            var yeniBottom = Bottom + HareketMesafesi;
            var tasacakMi = yeniBottom > HareketAlaniBoyutlari.Height;

            Bottom = tasacakMi ? HareketAlaniBoyutlari.Height : yeniBottom;

            return Bottom == HareketAlaniBoyutlari.Height;
        }

        private bool SagaHareketEttir()
        {
            if (Right == HareketAlaniBoyutlari.Width) return true;

            var yeniRight = Right + HareketMesafesi;
            var tasacakMi = yeniRight > HareketAlaniBoyutlari.Width;

            Right = tasacakMi ? HareketAlaniBoyutlari.Width : yeniRight;

            return Right == HareketAlaniBoyutlari.Width;
        }

        private bool YukariHareketEttir()
        {
            if (Top == 0) return true;

            var yeniTop = Top - HareketMesafesi;
            var tasacakMi = yeniTop < 0;
            Top = tasacakMi ? 0 : yeniTop;

            return Top == 0;
        }

        public bool ToplanildiMi(Toplayici toplayici)
        {
            var toplanildiMi = toplayici.Top < Bottom && toplayici.Right > Left && toplayici.Left < Right;
            if (toplanildiMi) return true;
            else return false;
        }
    }
}
