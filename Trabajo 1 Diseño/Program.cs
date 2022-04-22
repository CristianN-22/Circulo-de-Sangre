// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var socio = new Carga.Socio();
var clasificar = new Clasificacion.Clasificacion();

int opcion;
do
{
    Console.WriteLine("-----------");
    Console.WriteLine("Ingrese la operacion que desea realizar: ");
    Console.WriteLine(
        "Salir                            0\n" +
        "Cargar un asociado               1\n" +
        "Mostrar lista de asociados       2");
    Console.WriteLine("-----------");

    opcion = Convert.ToInt32(Console.ReadLine());

    if (opcion == 1)
    {
       
        socio.carga();
    }
    if (opcion == 2)
    {
        socio.mostrar();
    }
    
}while (opcion!=0 || opcion<0 || opcion>4);