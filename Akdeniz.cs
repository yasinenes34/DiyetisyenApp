using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenApp
{
    public class Akdeniz:IDiyetTipi
    {
        public string Diyet()
        {
            return this.AkdenizDiyet();
        }
        private string AkdenizDiyet()
        {
            return "AkdenizDiyet";
        }
    }
}
