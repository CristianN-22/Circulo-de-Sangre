using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Cobro
{
    class Usuario
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

        public Usuario()
        {
            this.tarjetas = new List<Tarjeta>();
            this.pedidos = new List<Pedido>();
        }

        public Usuario(string nombre, string dni, string provincia)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.provincia = provincia;
            this.tarjetas = new List<Tarjeta>();
            this.pedidos = new List<Pedido>();
        }

        public void NuevoUsuario()
        {
            Console.WriteLine("Ingrese el nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el DNI: ");
            dni = Console.ReadLine();

            Console.WriteLine("Ingrese la provincia en donde reside: ");
            provincia = Console.ReadLine();
        }

        public void AgregarTarjeta(Tarjeta tarjeta)
        {
            tarjetas.Add(tarjeta);
        }

        public void AgregarPedido(Pedido pedido)
        {
            pedidos.Add(pedido);
        }

        public void ToStringUsuario()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("DNI: " + dni);
            Console.WriteLine("Provincia: " + provincia);
        }
    }
}
