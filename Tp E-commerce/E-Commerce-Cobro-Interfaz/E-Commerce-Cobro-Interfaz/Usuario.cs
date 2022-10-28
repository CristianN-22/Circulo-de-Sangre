using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Cobro_Interfaz
{
    internal class Usuario
    {
        private String nombre;
        private String dni;
        private String provincia;
        private List<Pedido> pedidos;
        private List<Tarjeta> tarjetas;

        public String Nombre { get => nombre; set => nombre = value; }
        public String Dni { get => dni; set => dni = value; }
        public String Provincia { get => provincia; set => provincia = value; }
        public List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }
        public List<Tarjeta> Tarjeta { get => tarjetas; set => tarjetas = value; }
 
    }
}
