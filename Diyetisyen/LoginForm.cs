using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiyetisyenApp.DB;

namespace DiyetisyenApp
{
    public partial class LoginForm : Form
    {

        private readonly DiyetisyenContext _db;
        public LoginForm()
        {
            InitializeComponent();
            _db = new DiyetisyenContext();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                var KullaniciAdi = TB_USERNAME.Text.Trim();
                var sifre = TB_PASS.Text;
                var user = _db.KullaniciTables.FirstOrDefault(q => q.KullaniciAdi == KullaniciAdi && q.Sifre == sifre);
                if (user == null)
                {
                    MessageBox.Show("Hatali Sifre Veya Kullanici Adi Girdiniz ...", "Hatali Giris", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (user.KullaniciAdi == "admin")
                {                 
                     AdminForm af = new AdminForm();
                     this.Hide();
                     af.Show();
                }
                else
                {
                    DiyetForm df = new DiyetForm(user.KullaniciAdi);
                    this.Hide();
                    df.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.White;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Black;
        }
    }
}
