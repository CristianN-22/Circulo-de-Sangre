using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasificacion
{
    public class Clasificacion
    {
        string queseyo;

        public string clasificar (DateTime fecha, Boolean enfer)
        {
            if (enfer == true)
            {
                queseyo = "Pasivo";
            }
            else
            {
                DateTime aux = fecha.AddYears(18);
                DateTime aux2 = fecha.AddYears(57);

                if(aux > DateTime.Now || aux2 <= DateTime.Now)
                {
                    queseyo = "Pasivo";
                }
                else
                {

                    queseyo = "Activo";
                }
               
            }
            return queseyo;
        }
    }
}
