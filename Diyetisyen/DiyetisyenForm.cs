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
    public partial class DiyetForm : Form
    {
        private DiyetisyenContext _db;
        readonly yaziSartlari _sart;
        private string _diyetisyenAdi;
        public DiyetForm(string DiyetisyenAdi)
        {
            InitializeComponent();
            _diyetisyenAdi = DiyetisyenAdi;
            _db = new DiyetisyenContext();
            _sart = new yaziSartlari();
        }
        private void DiyetForm_Load(object sender, EventArgs e)
        {
            lbl_Diyetisyen_Adi.Text = _diyetisyenAdi;

            var hastaList = _db.HastaTables.ToList();
            foreach (var l in hastaList)
            {
               
                ListViewItem addhasta = new ListViewItem(l.Id.ToString());
                addhasta.SubItems.Add(l.adi);
                addhasta.SubItems.Add(l.hastalikTipi);
                addhasta.SubItems.Add(l.uygulanacakDiyet);
                HastaList.Items.Add(addhasta);
               
            }



        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            if (txt_hasta_ad.Text == "" && txt_hasta_kilo.Text == "" && txt_hasta_soyad.Text == "" && txt_hasta_tc.Text == "" && txt_hasta_yas.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız..", "Boş Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var hasta = new HastaTable
                {
                   adi =  txt_hasta_ad.Text,
                   kilo = int.Parse(txt_hasta_kilo.Text) ,
                   soyadi =  txt_hasta_soyad.Text,
                   tc =  txt_hasta_tc.Text,
                   yas= int.Parse(txt_hasta_yas.Text),
                   hastalikTipi = CB_Hastalik_Tipi.Text,
                   uygulanacakDiyet = CB_Uygulanacak_Diyet.Text
                };


                //diyet ve hastalik fabrikalari uygulamasi
                IHastalikTipi hastalik = HastaFabrikasi.HastaOlustur(CB_Hastalik_Tipi.Text);
                IDiyetTipi diyet = DiyetFabrikasi.DiyetOlustur(CB_Uygulanacak_Diyet.Text);
                // factory implementation -------------------------
                MessageBox.Show(hastalik.hastalik(), "Hastalik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(diyet.Diyet(), "Diyet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //-------------------------------------------------

                _db.HastaTables.Add(hasta);       
                _db.SaveChanges();
                 MessageBox.Show("Hasta Kaydı ve Diyet Atama Başarıyla Tamamlanmıştır!", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 txt_hasta_ad.Text = "";
                 txt_hasta_kilo.Text = "";
                 txt_hasta_soyad.Text = "";
                 txt_hasta_tc.Text = "";
                 txt_hasta_yas.Text = "";
            }
            if (HastaList.SelectedItems.Count>0)
            {
                HastaList.Items.Clear();
            }
            var hastaList = _db.HastaTables.ToList();
            foreach (var l in hastaList)
            {

                ListViewItem addhasta = new ListViewItem(l.Id.ToString());
                addhasta.SubItems.Add(l.adi);
                addhasta.SubItems.Add(l.hastalikTipi);
                addhasta.SubItems.Add(l.uygulanacakDiyet);
                HastaList.Items.Add(addhasta);

            }

        }

        private void txt_hasta_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            _sart.AllowNumberOnly(e, txt_hasta_tc, errorProvider1);
        }

        private void txt_hasta_kilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _sart.AllowNumberOnly(e, txt_hasta_tc, errorProvider2);
        }

        private void txt_hasta_yas_KeyPress(object sender, KeyPressEventArgs e)
        {
            _sart.AllowNumberOnly(e, txt_hasta_tc, errorProvider3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (HastaList.SelectedItems.Count >0)
            {
                int id = int.Parse( HastaList.SelectedItems[0].SubItems[0].Text);
                var getHasta = _db.HastaTables.Find(id);

                MessageBox.Show(getHasta.adi);
                var hastaAdi = getHasta.adi;
                var hastaSoyadi = getHasta.soyadi;
                var hastaTc = getHasta.tc;
                var hastaKilosu = getHasta.kilo;
                var hastaYasi = getHasta.yas;
                var hastaDiyet = getHasta.uygulanacakDiyet;
                var hastaHastalik = getHasta.hastalikTipi;

                // print paitent data to json and html report 
            }
            
        }





    }
}
