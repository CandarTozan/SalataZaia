using System;
using System.Windows.Forms;

namespace SalataZaia.Desktop
{
    public partial class MenuForm : Form
    {

        OyunForm oyunForm;

        public MenuForm()
        {
            InitializeComponent();
        }
        
        private void baslatButton_Click(object sender, EventArgs e)
        {
            if (!DolduMu()) return;
            else
            {
                int sure = Convert.ToInt32(suretxt.Text);
                oyunForm = new OyunForm(adtxt.Text, soyadtxt.Text, uruntxt.Text,
                Convert.ToInt32(miktartxt.Text), sure);
                oyunForm.Show();
            }
        }

        private bool DolduMu()
        {
            if (String.IsNullOrEmpty(adtxt.Text) || String.IsNullOrEmpty(soyadtxt.Text)
                || String.IsNullOrEmpty(uruntxt.Text) || String.IsNullOrEmpty(miktartxt.Text)
                || String.IsNullOrEmpty(suretxt.Text)) return false;

            return true;
        }
    }
}
