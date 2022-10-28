using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Cobro_Interfaz
{
    internal class Producto
    {
        private String nombre;
        private String descripcion;
        private decimal precio;
        private Pedido pedidos;

        public String Nombre { get => nombre; set => nombre = value; }
        public String Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public Pedido Pedidos { get => pedidos; set => pedidos = value; }

        public Producto(string nombre, string descripcion, decimal precio)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
        }

    }
}
