using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
