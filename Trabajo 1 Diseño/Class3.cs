using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carga;


namespace Pedidos
{
    public class Pedido
    {
        string nombre;
        DateOnly fechaLimite;
        int cantDonantes;
        string tipoSangre;
        string Estado = "Incompleto";

        public List <Pedido> ListaPedidos = new List <Pedido>();
        

        bool aux = false;
        
        public void CargaPedido()
        {

            var pedidoNuevo = new Pedido();
            Console.WriteLine("Ingresar el Nombre del Pedido");
            pedidoNuevo.nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingresar la fecha limite para el cumplimiento del pedido: ");
            aux = DateOnly.TryParse(Console.ReadLine(), out pedidoNuevo.fechaLimite);
            while (aux == false || pedidoNuevo.fechaLimite < DateOnly.FromDateTime(DateTime.Now))
            {
                Console.WriteLine("Por favor ingrese un formato de fecha correcto");
                aux = DateOnly.TryParse(Console.ReadLine(), out pedidoNuevo.fechaLimite);
            }

            Console.WriteLine("Ingresar lacantida de donantes necesarios: ");
            aux = int.TryParse(Console.ReadLine(), out pedidoNuevo.cantDonantes);
            while(aux == false || pedidoNuevo.cantDonantes < 0)
            {
                Console.WriteLine("Por favor ingrese una cantidad de donantes correcta: ");
                aux = int.TryParse(Console.ReadLine(), out pedidoNuevo.cantDonantes);
            }

            Console.WriteLine("Elegir el tipo de Sangre necesario: \n" +
                "1- A RH Negativo\n" +
                "2- B RH Negativo\n" +
                "3- AB RH Negativo\n" +
                "4- 0 RH Negativo\n");
            aux = int.TryParse(Console.ReadLine(), out int auxOp);
            while (aux == false || auxOp<1 || auxOp > 4)
            {
                Console.WriteLine("Elija una opcion que exista: ");
                aux = int.TryParse(Console.ReadLine(), out auxOp);
            }
            switch (auxOp)
            {
                case 1:
                    pedidoNuevo.tipoSangre = "A RH Negativo";
                    break;
                case 2:
                    pedidoNuevo.tipoSangre = "B RH Negativo";
                    break;
                case 3:
                    pedidoNuevo.tipoSangre = "AB RH Negativo";
                    break;
                case 4:
                    pedidoNuevo.tipoSangre = "0 RH Negativo";
                    break;
            }
            
            ListaPedidos.Add(pedidoNuevo);
            


        }

        public void Donantes(string nom, string ape, string sangre)
        {
            
            foreach(var i in ListaPedidos)
            {
                Console.WriteLine(i.nombre);
                if (i.Estado == "Incompleto")
                {
                    int cant = 0;
                    while(cant < i.cantDonantes || nom!=null)
                    {
                        bool aux = false;
                        if(sangre == i.tipoSangre)
                        {
                            int op;
                            Console.WriteLine("Sr. " + nom + ape + "puede presentarse a donar sangre antes del el dia " + i.fechaLimite + "?");
                            Console.WriteLine("\n 1-    Si\n" +
                                " 2-    No");
                            aux = int.TryParse(Console.ReadLine(), out op);
                            while(aux==false || op<1 || op > 2)
                            {
                                Console.WriteLine("Por favor ingrese un formato correcto");
                                Console.WriteLine("Sr. " + nom + ape + "puede presentarse a donar sangre antes del el dia " + i.fechaLimite + "?");
                                Console.WriteLine("\n 1-    Si\n" +
                                    " 2-    No");
                                aux = int.TryParse(Console.ReadLine(), out op);
                            }
                            if (op == 1)
                            {
                                cant = cant + 1;
                            }
                        }
                        
                    }
                    i.Estado = "Completado";
                }
            }
        }
        


    }

    
}
