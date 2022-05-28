// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var socio = new Carga.Socio();
var pedido = new Pedidos.Pedido();

int opcion;
bool isOpcion;
do
{
    do
    {
        Console.WriteLine("-----------");
        Console.WriteLine("Ingrese la operacion que desea realizar: ");
        Console.WriteLine(
            "Salir                            0\n" +
            "Cargar un asociado               1\n" +
            "Mostrar lista de asociados       2\n" +
            "Cargar un nuevo pedido           3\n" +
            "Enviar solicitud a donantes      4");
        Console.WriteLine("-----------");

             isOpcion = int.TryParse(Console.ReadLine(), out opcion);

    } while ( isOpcion == false);

    if (opcion == 1)
    {
        socio.carga();
    }
    if (opcion == 2)
    {
        socio.mostrar();
    }
    if (opcion == 3)
    {
        pedido.CargaPedido();
    }
    if(opcion == 4)
    {
        socio.enviardatos();
    }
    
}while (opcion!=0 || opcion<0 || opcion>4);