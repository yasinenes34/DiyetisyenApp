using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetisyenApp
{
    class yaziSartlari
    {
        public void AllowNumberOnly(KeyPressEventArgs e, TextBox txt, ErrorProvider err)
        {
            string Numbers = "0123456789" + "\b" + "\t";
            if (Numbers.IndexOf(e.KeyChar) == -1)
            {
                e.Handled = true;
                err.SetError(txt, "Sadece Rakam Girebilirsiniz!");
            }
            else
            {
                e.Handled = false;
                err.SetError(txt, "");
            }

        }
        public void AllowTextOnly(KeyPressEventArgs e, TextBox txt, ErrorProvider err)
        {
            string Numbers = "0123456789";
            if (Numbers.IndexOf(e.KeyChar) == -1)
            {
                e.Handled = false;
                err.SetError(txt, "");
            }
            else
            {
                e.Handled = true;
                err.SetError(txt, "Sadece Rakam Girebilirsiniz!");
            }

        }
        public void denaySpace(KeyPressEventArgs e, TextBox txt, ErrorProvider err)
        {
            string Numbers = " ";
            if (Numbers.IndexOf(e.KeyChar) == -1)
            {
                e.Handled = false;
                err.SetError(txt, "");
            }
            else
            {
                e.Handled = true;
                err.SetError(txt, "Mesafe Eklenmez!");
            }
        }
    }
}
