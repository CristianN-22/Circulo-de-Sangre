using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Cobro_Interfaz
{
    internal class Tarjetaclass
    {
        private String numero;
        private String titular;
        private int dniTitular;
        private DateTime vencimiento;
        private int codSeguridad;
        private TipoTarjeta tipo;
        private int cantCuota;


        public String Numero { get => numero; set => numero = value; }
        public String Titular { get => titular; set => titular = value; }
        public int DniTitular { get => dniTitular; set => dniTitular = value; }
        public DateTime Vencimiento { get => vencimiento; set => vencimiento = value; }
        public int CodSeguridad { get => codSeguridad; set => codSeguridad = value; }
        public TipoTarjeta Tipo { get => tipo; set => tipo = value; }
        public int CantCuota { get => cantCuota; set => cantCuota = value; }



        public Tarjetaclass(string numero, string titular, int dniTitular, DateTime vencimiento, int codSeguridad, int cantCuota, TipoTarjeta tipo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.DniTitular = dniTitular;
            this.Vencimiento = vencimiento;
            this.CodSeguridad = codSeguridad;
            this.CantCuota = cantCuota;
            this.Tipo = tipo;

        }
    }
}
enum TipoTarjeta
{
    Debito,
    Credito
}
