using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalataZaia.Desktop
{
    public partial class OyunForm : Form
    {
        public OyunForm(string ad, string Soyad, string urunAd, int urunMiktar, int sure)
        {
            InitializeComponent();
            string _ad = ad;
            string _soyad = Soyad;
            string _urunad = urunAd;
            int _urunMiktar = urunMiktar;
            int _sure = sure;
        }
    }
}
