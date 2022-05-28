using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catergoria
{
    public class Clasificacion
    {
        string categoria;

        public string clasificar (DateTime fecha, String enfer)
        {
            if (enfer != "No")
            {
                categoria = "Pasivo";
            }
            else
            {
                DateTime aux = fecha.AddYears(18);
                DateTime aux2 = fecha.AddYears(57);

                if(aux > DateTime.Now || aux2 <= DateTime.Now)
                {
                    categoria = "Pasivo";
                }
                else
                {

                    categoria = "Activo";
                }
               
            }
            return categoria;
        }

    }
}
