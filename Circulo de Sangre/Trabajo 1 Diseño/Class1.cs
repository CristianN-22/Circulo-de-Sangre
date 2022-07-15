using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catergoria;
using Pedidos;

namespace Carga
{
    public class Socio
    {
        Catergoria.Clasificacion clasi = new Catergoria.Clasificacion();
        Pedidos.Pedido pedi = new Pedidos.Pedido();

        string nombre;
        string apellido;
        string dni;
        DateTime fechanac;
        string domicilio;
        string localidad;
        long telefono;
        string email;
        string tipoSangre;
        string enfermedad = "No";
        string medicacion = "Ninguno";
        string categoria;
        int donaciones = 0;

        public List <Socio> socios = new List<Socio>();
        public List <Socio> activos = new List<Socio>();

        public void carga()
        {
            var socio1 = new Socio();
            int posee;
            bool aux = false;
            do
            {
              
                Console.WriteLine("¿Posee Factor RH Negativo?: " +
                "\n 1 - Si " +
                "\n 2 - No");
                aux = int.TryParse(Console.ReadLine(), out posee);
            } while (aux == false || posee>2 || posee<1);

            if (posee == 1)
            {
                Console.WriteLine("Elegir el tipo de Sangre necesario: \n" +
                "1- A RH Negativo\n" +
                "2- B RH Negativo\n" +
                "3- AB RH Negativo\n" +
                "4- 0 RH Negativo\n");
                aux = int.TryParse(Console.ReadLine(), out int auxOp);
                while (aux == false || auxOp < 1 || auxOp > 4)
                {
                    Console.WriteLine("Elija una opcion que exista: ");
                    aux = int.TryParse(Console.ReadLine(), out auxOp);
                }
                switch (auxOp)
                {
                    case 1:
                        socio1.tipoSangre = "A RH Negativo";
                        break;
                    case 2:
                        socio1.tipoSangre = "B RH Negativo";
                        break;
                    case 3:
                        socio1.tipoSangre = "AB RH Negativo";
                        break;
                    case 4:
                        socio1.tipoSangre = "0 RH Negativo";
                        break;
                }

                Console.WriteLine("Ingrese el D.N.I: ");
                socio1.dni = Console.ReadLine();

                Console.WriteLine("Ingrese el nombre de la persona: ");
                socio1.nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el apellido: ");
                socio1.apellido = Console.ReadLine();

                do
                {
                    Console.WriteLine("Ingrese la fecha de nacimiento: ");
                    aux = DateTime.TryParse(Console.ReadLine(), out socio1.fechanac);

                } while (aux == false);

                Console.WriteLine("Ingrese el domicilio: ");
                socio1.domicilio = Console.ReadLine();

                Console.WriteLine("Ingrese la localidad de residencia: ");
                socio1.localidad = Console.ReadLine();

                do
                {
                    Console.WriteLine("Ingrese el numero de telefono: ");
                    aux = long.TryParse(Console.ReadLine(), out socio1.telefono);
                } while (aux == false);

                Console.WriteLine("Ingrese el email: ");
                socio1.email = Console.ReadLine();



                int j;
                do
                {
                    Console.WriteLine("Posee alguna enfermedad crónica: " +
                        "\n 1- Si" +
                        "\n 2- No");
                    aux = int.TryParse(Console.ReadLine(), out j);
                } while (aux == false);
                if (j == 1 || j < 1 || j > 2)
                {
                    Console.WriteLine("Ingrese la enfermedad que tiene: ");
                    socio1.enfermedad = Console.ReadLine();
                    Console.WriteLine("Ingrese la medicacion que debe tomar: ");
                    socio1.medicacion = Console.ReadLine();
                }

                socio1.categoria = clasi.clasificar(socio1.fechanac, socio1.enfermedad);

                Console.WriteLine("Los Terminos y condiciones son:" +
                    "\n ..." +
                    "\n ..." +
                    "\n ..." +
                    "\n ..." +
                    "\n ..." +
                    "\n 1 - Aceptar" +
                    "\n 2 - Denegar");

                aux = int.TryParse(Console.ReadLine(), out j);
                while (aux == false || j > 2 || j < 1)
                {
                    Console.WriteLine("Por favor ingrese un formato correcto");
                    Console.WriteLine("Los Terminos y condiciones son:" +
                    "\n ..." +
                    "\n ..." +
                    "\n ..." +
                    "\n ..." +
                    "\n ..." +
                    "\n 1 - Aceptar" +
                    "\n 2 - Denegar");
                    aux = int.TryParse(Console.ReadLine(), out j);
                }
                if (j == 1)
                {
                    Console.WriteLine("Se registro con exito");

                    socios.Add(socio1);
                    if (socio1.categoria == "Activo")
                    {
                        activos.Add(socio1);
                    }
                }

            }
            else
            {
                Console.WriteLine("Lo siento tiene que ser RH Negativo");
            }
        }

        internal void enviardatos()
        {
            foreach(var i in activos)
            {
                pedi.Donantes(i.nombre, i.apellido, i.tipoSangre);
            }
            if (socios.Count == 0)
            {
                Console.WriteLine("No existen socios activos");
            }
        }
        internal void mostrar()
        {
            int cont = 0;
           foreach (var i in socios)
            {
                cont = cont + 1;
                Console.WriteLine("\nLos datos del Socio " + cont + " son: ");
                Console.WriteLine(i.nombre);
                Console.WriteLine(i.apellido);
                Console.WriteLine("D.N.I: " + i.dni);
                Console.WriteLine("Fecha de nacimiento: " + i.fechanac.ToString("dd/MM/yyyy"));
                Console.WriteLine(i.domicilio);
                Console.WriteLine(i.localidad);
                Console.WriteLine(i.telefono);
                Console.WriteLine(i.email);
                Console.WriteLine(i.tipoSangre); 
                Console.WriteLine("Enfermedades: "+ i.enfermedad);
                Console.WriteLine("Medicamento que utiliza: "+ i.medicacion);
                Console.WriteLine("CATEGORIA: " + i.categoria);
           }
        }
    }
    
}
