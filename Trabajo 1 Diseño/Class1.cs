using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clasificacion;

namespace Carga
{

    public class Socio
    {
        Clasificacion.Clasificacion clasi = new Clasificacion.Clasificacion();
        //DNI, nombre
        //apellido, fecha de nacimiento, domicilio, localidad, teléfono, email, grupo sanguíneo y factor; además
        //deberá informar si tiene alguna enfermedad crónica y si toma medicación de forma permanente,
        //indicar que medicación

        string nombre;
        string apellido;
        string dni;
        DateTime fechanac;
        string domicilio;
        string localidad;
        long telefono;
        string email;
        string gruposanguineo;
        string factor;
        Boolean enfermedad=false;
        string medicacion="ninguna";
        string categoria;

        List <Socio> socios = new List<Socio>();

        public void carga()
        {
            var socio1 = new Socio();

            Console.WriteLine("¿Posee Factor RH Negativo?: " +
                "\n 1 - Si " +
                "\n 2 - No");

            int posee = Convert.ToInt32(Console.ReadLine());
            while(posee>2 || posee < 1){
                Console.WriteLine("Por favor ingrese un formato correcto");
                Console.WriteLine("¿Posee Factor RH Negativo?: " +
                "\n 1 - Si " +
                "\n 2 - No");

                posee = Convert.ToInt32(Console.ReadLine());
            }
            if (posee == 1)
            {
                Console.WriteLine("Ingrese el grupo sanguineo: ");
                socio1.gruposanguineo = Console.ReadLine() + " RH Negativo";

                Console.WriteLine("Ingrese el D.N.I: ");
                socio1.dni =Console.ReadLine();

                Console.WriteLine("Ingrese el nombre de la persona: ");
                socio1.nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el apellido: ");
                socio1.apellido = Console.ReadLine();

                Console.WriteLine("Ingrese la fecha de nacimiento: ");
                socio1.fechanac = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Ingrese el domicilio: ");
                socio1.domicilio = Console.ReadLine();

                Console.WriteLine("Ingrese la localidad de residencia: ");
                socio1.localidad = Console.ReadLine();

                Console.WriteLine("Ingrese el numero de telefono: ");
                socio1.telefono = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Ingrese el email: ");
                socio1.email = Console.ReadLine();

                

                

                Console.WriteLine("Posee alguna enfermedad crónica: " +
                    "\n 1- Si" +
                    "\n 2- No");
                int j = Convert.ToInt32(Console.ReadLine());
                if (j == 1)
                {
                    socio1.enfermedad = true;
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
                j = Convert.ToInt32(Console.ReadLine());
                while(j > 2 || j < 1)
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
                    j = Convert.ToInt32(Console.ReadLine());
                }
                if (j == 1)
                {
                    Console.WriteLine("Se registro con exito");

                    socios.Add(socio1);
                }
                
            }
            else
            {
                Console.WriteLine("Lo siento tiene que ser RH Negativo");
            }
            
        }

        public void mostrar()
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
                //Console.WriteLine(i.telefono);
                //Console.WriteLine(i.email);
                Console.WriteLine(i.gruposanguineo); 
                //Console.WriteLine(i.enfermedad.ToString());
                //Console.WriteLine(i.medicacion);
                Console.WriteLine("CATEGORIA: " + i.categoria);
            }
        }
    }
    
}
