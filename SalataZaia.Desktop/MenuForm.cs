using System;
using System.Windows.Forms;

namespace SalataZaia.Desktop
{
    public partial class MenuForm : Form
    {

        OyunForm oyunForm;
        TusBilgiForm tusBilgiForm;

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
                oyunForm.ShowDialog();
            }
        }

        private bool DolduMu()
        {
            if (String.IsNullOrEmpty(adtxt.Text) || String.IsNullOrEmpty(soyadtxt.Text)
                || String.IsNullOrEmpty(uruntxt.Text) || String.IsNullOrEmpty(miktartxt.Text)
                || String.IsNullOrEmpty(suretxt.Text)) return false;

            return true;
        }

        private void miktartxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void suretxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tusBilgiPanel_Click(object sender, EventArgs e)
        {
            tusBilgiForm = new TusBilgiForm();
            tusBilgiForm.ShowDialog();
        }
    }
}
