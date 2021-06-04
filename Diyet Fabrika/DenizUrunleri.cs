using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenApp
{
    public class DenizUrunleri:IDiyetTipi
    {
        public string Diyet()
        {
            return this.DenizDiyet();
        }
        private string DenizDiyet()
        {
            return "DenizDiyet";
        }
    }
}
