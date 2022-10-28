using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Cobro_Interfaz
{
    public class Cuota
    {

        public decimal CalcularMontoCuotas(int cantCuota, decimal montoTotal)
        {
            decimal montoCuotas;

            if (cantCuota == 1)
            {
                montoCuotas = montoTotal;
                return montoCuotas;
            }
            else if (cantCuota == 3)
            {
                montoCuotas = (montoTotal / cantCuota) * 1.05M;
                return montoCuotas;
            }
            else if (cantCuota == 6)
            {
                montoCuotas = (montoTotal / cantCuota) * 1.10M;
                return montoCuotas;
            }
            else
            {
                montoCuotas = (montoTotal / 12) * 1.15M;
                return montoCuotas;
            }
        }
    }
}
