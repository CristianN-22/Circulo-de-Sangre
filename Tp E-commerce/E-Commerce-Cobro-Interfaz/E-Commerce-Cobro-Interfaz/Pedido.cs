using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Cobro_Interfaz
{
    internal class Pedido
    {

        private decimal montoFinal;
        private DateTime fecha;
        private Usuario usuarios;
        private List<Producto> productos;

        public decimal MontoFinal { get => montoFinal; set => montoFinal = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Usuario Usuarios { get => usuarios; set => usuarios = value; }
        public List<Producto> Productos { get => productos; set => productos = value; }
      
    }
}
