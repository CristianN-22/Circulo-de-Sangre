using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using E_Commerce_Cobro;

namespace ecommerce
{
    public class Program
    {
        static List<Producto> productos = new List<Producto>();

        static void Main(string[] args)
        {
            Pedido pedido = DeserializarCarritoDTO();
            Usuario usuario = DeserializarUsuarioDTO();
            pedido.Usuarios = usuario;

            int opcion;
            string linea;

            do
            {
                Console.WriteLine("\t---E-Commerce---\n");
                Console.WriteLine("¿Desea confirmar la compra?");
                Console.WriteLine("1. Confirmar.");
                Console.WriteLine("2. Cancelar.");
                linea = Console.ReadLine();
                opcion = int.Parse(linea);
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        SeleccionarMetodoDePago();
                        break;

                    case 2:
                        Console.WriteLine("\nOperacion cancelada.");
                        //Vuelve al carrito de compras
                        break;

                    default:
                        Console.WriteLine("\nOpcion incorrecta. Ingrese nuevamente!\n");
                        break;
                }

            } while (opcion != 1 && opcion != 2);
        }

        public static void SeleccionarMetodoDePago()
        {
            int opcionPago;
            string linea;
            decimal total = 0M;

            DateTime vencimiento1 = new DateTime(2023, 12, 20);
            DateTime vencimiento2 = new DateTime(2024, 08, 12);
            DateTime fechaPedido = DateTime.Now;

            Usuario usuario1 = new Usuario("Tadeo Cervellati", "42000111", "Cordoba");
            Usuario usuario2 = new Usuario("Federico Audizio", "22159753", "Santa Fe");

            Producto producto1 = new Producto("Remera IGGOR", "Remera Oversize rosada XL", 2520.0M);
            Producto producto2 = new Producto("Buzo Trasher", "Buzo Oversize negro XL", 7260.0M);

            total = producto1.Precio + producto2.Precio;

            Pedido pedido = new Pedido(total, fechaPedido);

            productos.Add(producto1);
            productos.Add(producto2);

            do
            {
                Console.WriteLine("Seleccionar forma de pago: ");
                Console.WriteLine("1. Tarjeta de Debito.");
                Console.WriteLine("2. Tarjeta de Credito.");
                Console.WriteLine("3. Cancelar.");
                linea = Console.ReadLine();
                opcionPago = int.Parse(linea);
                Console.Clear();

                switch (opcionPago)
                {

                    case 1:
                        int opcion;

                        Tarjeta tarjeta1 = new Tarjeta("123456789", "Tadeo Cervellati", 42000111, "Santander Rio", vencimiento1, 123, TipoTarjeta.Debito, usuario1);
                        usuario1.AgregarTarjeta(tarjeta1);

                        do
                        {
                            Console.WriteLine("¿Desea usar la tarjeta registrada? A continuacion, las tarjetas de debito registradas: ");
                            tarjeta1.ToStringTarjeta();
                            Console.WriteLine("\n1. Si.");
                            Console.WriteLine("2. No. Deseo agregar una nueva.");
                            opcion = int.Parse(Console.ReadLine());
                            Console.Clear();

                            if (opcion == 1)
                            {
                                Pago pagoConDebito = new Pago(total, fechaPedido, tarjeta1);

                                pagoConDebito.PagoTarjetaDebito();

                                MostrarPedido(pedido, usuario1, pagoConDebito);
                            }

                            else if (opcion == 2)
                            {
                                Usuario usuarioNuevo = new Usuario();
                                Tarjeta tarjetaNueva = new Tarjeta(usuarioNuevo);

                                tarjetaNueva.NuevaTarjeta();

                                Pago pagoTarjetaNueva = new Pago(total, fechaPedido, tarjetaNueva);

                                pagoTarjetaNueva.PagoTarjetaDebito();

                                MostrarPedido(pedido, usuarioNuevo, pagoTarjetaNueva);
                            }

                            else
                            {
                                Console.WriteLine("\nOpcion incorrecta, ingrese nuevamente.");
                            }

                        } while (opcion != 1 && opcion != 2);

                        break;

                    case 2:
                        Tarjeta tarjeta2 = new Tarjeta("987654321", "Fernando Cervellati", 18222333, "Macro", vencimiento2, 456, TipoTarjeta.Credito, usuario2);
                        usuario2.AgregarTarjeta(tarjeta2);

                        do
                        {
                            Console.WriteLine("¿Desea usar la tarjeta registrada? A continuacion, las tarjetas de credito registradas: ");
                            tarjeta2.ToStringTarjeta();
                            Console.WriteLine("\n1. Si.");
                            Console.WriteLine("2. No. Deseo agregar una nueva.");
                            opcion = int.Parse(Console.ReadLine());
                            Console.Clear();

                            if (opcion == 1)
                            {
                                Pago pagoConCredito = new Pago(total, fechaPedido, tarjeta2);

                                pagoConCredito.PagoTarjetaCredito();

                                MostrarPedido(pedido, usuario2, pagoConCredito);
                            }

                            else if (opcion == 2)
                            {
                                Usuario usuarioNuevo = new Usuario();
                                Tarjeta tarjetaNueva = new Tarjeta(usuarioNuevo);

                                tarjetaNueva.NuevaTarjeta();

                                Pago pagoTarjetaNueva = new Pago(total, fechaPedido, tarjetaNueva);

                                pagoTarjetaNueva.PagoTarjetaCredito();

                                MostrarPedido(pedido, usuarioNuevo, pagoTarjetaNueva);
                            }

                            else
                            {
                                Console.WriteLine("\nOpcion incorrecta, ingrese nuevamente.");
                            }

                        } while (opcion != 1 && opcion != 2);

                        break;

                    case 3:
                        Console.WriteLine("\nOperacion cancelada.");
                        break;

                    default:
                        Console.WriteLine("\nOpcion incorrecta. Ingrese nuevamente!\n");
                        break;

                }

            } while (opcionPago != 1 && opcionPago != 2 && opcionPago != 3 && opcionPago != 4);

        }
        internal static void MostrarPedido(Pedido pedido, Usuario usuario, Pago pago)
        {
            usuario.AgregarPedido(pedido);
            pedido.ToStringPedido(usuario, productos, pago);

        }

        static Pedido DeserializarCarritoDTO()
        {
            var carritoDTO = File.ReadAllText("carritoDTO.txt");
            var dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy HH:mm:ss" };
            var pedido = JsonConvert.DeserializeObject<Pedido>(carritoDTO, dateTimeConverter);

            return pedido;
        }

        static Usuario DeserializarUsuarioDTO()
        {
            var usuarioDTO = File.ReadAllText("UsuarioDTO.txt");
            var usuario = JsonConvert.DeserializeObject<Usuario>(usuarioDTO);

            return usuario;
        }
    }
}
