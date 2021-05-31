using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenApp
{
    class HastaFabrikasi
    {
        public IHastalikTipi hastaOlustur(string hastaTipi)
        {
            if (hastaTipi == "Obez")
            {
                return new Obez();
            }
            else if (hastaTipi == "Çölyak")
            {
                return new Colyak();

            }
            else if (hastaTipi == "Şeker")
            {
                return new SekerHastalik();
            }
            else
            {
                return null;
            }
        }
    }
}
