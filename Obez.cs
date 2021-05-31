using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenApp
{
    class Obez:IHastalikTipi
    {
        public string hastalik()
        {
            return this.obezHastalik();
        }
        private string obezHastalik()
        {
            return "Obez Hastalığı";
        }
    }
}
