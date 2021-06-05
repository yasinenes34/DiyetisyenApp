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
    public partial class DiyetisyenEkleForm : Form
    {
        private DiyetisyenContext _db;
        readonly yaziSartlari sart;
        public DiyetisyenEkleForm()
        {
            InitializeComponent();
            _db = new DiyetisyenContext();
            sart = new yaziSartlari();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" && txtSoyad.Text == "" && txtAd.Text == "" && txtTC.Text == "" && txtSifre1.Text == "" && txtSifre2.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz.", "Kayıt Olunmadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSifre1.Text == txtSifre2.Text)
            {

                var user = new KullaniciTable {  // _db.KullaniciTables.Create();
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Sifre = txtSifre1.Text,
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    TC = txtTC.Text
                };

                _db.KullaniciTables.Add(user);

                var role = new KullaniciRole {   // _db.UserRoles.Create();
                    userId = user.Id,
                    roleId = 2
                }; 
                _db.KullaniciRoles.Add(role);
                _db.SaveChanges();
                MessageBox.Show(txtKullaniciAdi.Text +" Diyetisyenin Kaydı Başarıyla Tamamlanmıştır!", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminForm af = new AdminForm();
                this.Hide();
                af.Show();

            }
            else
            {
                MessageBox.Show("Şifreler Eşleşmiyor, Lüfen Tekrar Deneyiniz.", "Kayıt Olunmadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSifre1.Text = "";
                txtSifre2.Text = "";
                txtSifre1.Focus();
            }
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            sart.AllowNumberOnly(e, txtTC, errorProvider1);
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            sart.denaySpace(e, txtKullaniciAdi, errorProvider2);
        }
        private void lblClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm a = new AdminForm();
            this.Hide();
            a.Show();
        }
    }
}
