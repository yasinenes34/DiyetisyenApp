using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenApp
{
    class SekerHastalik:IHastalikTipi
    {
        public string hastalik()
        {
            return this.sekerHastalik();
        }
        private string sekerHastalik()
        {
            return "Şeker Hastalığı";
        }
    }
}
