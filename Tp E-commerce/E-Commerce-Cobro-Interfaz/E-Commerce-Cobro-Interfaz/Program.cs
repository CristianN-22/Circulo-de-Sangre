using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace E_Commerce_Cobro_Interfaz
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            List<Producto> productos = new List<Producto>();
            Pedido pedido = DeserializarCarritoDTO();
            Usuario usuario = DeserializarUsuarioDTO();
            pedido.Usuarios = usuario;
          
            ApplicationConfiguration.Initialize();
            Application.Run(new Tarjeta());

            Tarjetaclass tarjeta = DeserializarTarjetaDTO();
            Cuota cuota = new Cuota();

            decimal montoCuota = cuota.CalcularMontoCuotas(tarjeta.CantCuota, pedido.MontoFinal);



            string facturaMostrar = ($"\nDatos del usario " +
                $"\r\nPedido a nombre de {usuario.Nombre} " +
                $"\r\nDNI: {usuario.Dni} " +
                $"\r\n\r\nDetalles de la compra " +
                $"\r\nEl monto total es de {pedido.MontoFinal}" +
                $"\r\nNúmero de Cuotas: {tarjeta.CantCuota}" +
                $"\r\nMonto de la cuota: {montoCuota}" +
                $"\r\nFecha del pedido: {pedido.Fecha.ToString("dd/MM/yyyy")}" +
                $"\r\n\r\nDatos de la tarjeta " +
                $"\r\nNúmero de tarjeta: {tarjeta.Numero}" +
                $"\r\nNombre del titular de la tarjeta: {tarjeta.Titular}" +
                $"\r\nVencimiento de la tarjeta: {tarjeta.Vencimiento.ToString("Y")}" +
                $"\r\nCódigo de Seguridad: {tarjeta.CodSeguridad}" +
                $"\r\nTipo de tarjeta: {tarjeta.Tipo}" );
              
            
            Application.Run(new Factura(facturaMostrar));

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

        static Tarjetaclass DeserializarTarjetaDTO()
        {
            var tarjetaDTO = File.ReadAllText("tarjetaDTO.txt");
            var tarjeta = JsonConvert.DeserializeObject<Tarjetaclass>(tarjetaDTO);

            return tarjeta;

        }


    }
}