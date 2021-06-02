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
    public partial class AdminForm : Form
    {
        private readonly DiyetisyenContext _db;
        public AdminForm()
        {
            InitializeComponent();
            _db = new DiyetisyenContext();
        }

        private void btnDiyetisyenEkle_Click(object sender, EventArgs e)
        {
            DiyetisyenEkleForm sf = new DiyetisyenEkleForm();
            this.Hide();
            sf.Show();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            var diyetisyenListesi = _db.KullaniciTables.ToList();
            foreach (var l in diyetisyenListesi)
            {
                if (l.TC != null)
                {
                    ListViewItem addDiyetisyen = new ListViewItem(l.Id.ToString());
                    addDiyetisyen.SubItems.Add(l.KullaniciAdi);
                    addDiyetisyen.SubItems.Add(l.TC);
                    DiyetisyenList.Items.Add(addDiyetisyen);
                }
            }



        }
    }
}
