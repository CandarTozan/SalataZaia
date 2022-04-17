// Geliştirici : Candar TOZAN
// Öğrenci NO : B211200027
// Nesneye Dayalı Programlama 1. Proje / Tasarım

using SalataZaia.Library.Enum;

namespace SalataZaia.Library.Interface
{
    internal interface IOyun
    {
        bool DevamEdiyorMu { get; }

        void Baslat();
        void DurDevam();
        void Bitir();
        void ToplayiciyiHareketEttir(Yon yon);
    }
}
