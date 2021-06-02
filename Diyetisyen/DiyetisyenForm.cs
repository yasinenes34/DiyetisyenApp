using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetisyenApp
{
    public partial class DiyetForm : Form
    {
        private string _diyetisyenAdi;
        public DiyetForm(string DiyetisyenAdi)
        {
            InitializeComponent();
            _diyetisyenAdi = DiyetisyenAdi;
        }

        private void DiyetForm_Load(object sender, EventArgs e)
        {
            lbl_Diyetisyen_Adi.Text = _diyetisyenAdi;
        }
    }
}
