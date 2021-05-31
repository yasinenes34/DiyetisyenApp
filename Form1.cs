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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiyetFabrikasi fabrika = new DiyetFabrikasi();
            IDiyetTipi diyet1 = fabrika.DiyetOlustur("Akdeniz");
            diyet1.Diyet();
            MessageBox.Show(diyet1.ToString());
        }
    }
}
