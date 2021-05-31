using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenApp
{
    public class DiyetFabrikasi
    {
        public  IDiyetTipi DiyetOlustur(string diyetTipi)
        {
            
            if (diyetTipi == "Deniz Ürünleri")
            {
                return new DenizUrunleri();
            }
            else if (diyetTipi == "Yeşillikler Dünyası")
            {
                return new YesilliklerDunya();

            }
            else if (diyetTipi == "Gluten Free")
            {
                return new GlutenFree();
            }
            else if (diyetTipi == "Akdeniz")
            {
                return new Akdeniz();
            }
            return null;
        }
    }
}
