using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int opcion;

                do
                {
                    Console.Clear();
                    opcion = Interfaz.PantallaPrincipal();

                    switch (opcion)
                    {
                        case 1:
                            opcion = Interfaz.IngresarNotas();
                            break;
                        case 2:
                            opcion = Interfaz.NotaMasAlta();
                            break;
                        case 3:
                            opcion = Interfaz.NotaMasBaja();
                            break;
                        case 4:
                            opcion = Interfaz.ListaDeEstudiantes();
                            break;

                        case 0:
                            break;
                    }
                } while (opcion != 5);


            }

        }
    }
}
