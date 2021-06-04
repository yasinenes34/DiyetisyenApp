using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenApp
{
    public class YesilliklerDunya:IDiyetTipi
    {
        public string Diyet()
        {
            return this.YesilliklerDiyet();
        }
        private string YesilliklerDiyet()
        {
            return "YesilliklerDiyet";
        }
    }
}
