using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenApp
{
    public class GlutenFree:IDiyetTipi
    {
        public string Diyet()
        {
            return this.GlutenFreeDiyet();
        }
        private string GlutenFreeDiyet()
        {
            return "GlutenFreeDiyet";
        }
    }
}
