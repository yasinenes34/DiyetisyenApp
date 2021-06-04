using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenApp
{
    public class HastaFabrikasi
    {
        public static IHastalikTipi HastaOlustur(string hastaTipi)
        {
            switch (hastaTipi)
            {
                case "Obez":
                    return new Obez();
                case "Çölyak":
                    return new Colyak();
                case "Şeker":
                    return new SekerHastalik();
                default:
                    return null;
            }
        }
    }
}
