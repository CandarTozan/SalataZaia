using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalataZaia.Library.Enum;

namespace SalataZaia.Library.Interface
{
    interface IOyun
    {

        event EventHandler GecenSureDegisti;
        bool DevamEdiyorMu { get; }
        TimeSpan GecenSure { get; }

        void Baslat();
        void Durdur();
        void Bitir();
        void ToplayiciyiHareketEttir(Yon yon);

    }
}
