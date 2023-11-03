using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_2
{
    internal class Interfaz
    {

        public static float[] notas = new float[7];
        public static int contador = 0;
        public static string[] nombres = new string[7];

        public static int PantallaPrincipal()
        {
            Console.Clear();

            string texto = "================================\n" +
                 "Notas de Estudiantes\n" +
                 "================================\n" +
                 "1: Ingresar Notas\n" +
                 "2: Nota más alta\n" +
                 "3: Nota más baja\n" +
                 "4: Ver lista de Estudiantes\n" +
                 "================================\n";

            Console.WriteLine(texto);

            return Operaciones.getEntero("Ingrese una opción:", texto);
        }

        public static int IngresarNotas()
        {
            int opcion = 0;

            do
            {
                Console.Clear();

                string texto = "================================\n" +
                               "Ingresar Nota\n" +
                               "================================\n" +
                               "Ingrese el nombre: ";

                string nombre = Operaciones.getTextoPantalla(texto);
                float nota = Operaciones.getDecimal("Ingrese la nota: ");

                if (contador < 7)
                {
                    nombres[contador] = nombre;
                    notas[contador] = nota;
                    contador++;
                }

                string textoGuardado = "================================\n" +
                                      "!Guardado\n" +
                                      "================================\n" +
                                      "1: Agregar uno más | 2: Volver\n";
                Console.WriteLine(textoGuardado);

                opcion = Operaciones.getEntero("Ingrese una opción:", textoGuardado);

            } while (opcion == 1 && contador < 7);

            return opcion;
        }

        public static int NotaMasAlta()
        {
            Console.Clear();

            string texto = "================================\n" +
                 "Nota mas alta\n" +
                 "================================\n";

            Console.WriteLine(texto);

            if (contador == 0)
            {
                Console.WriteLine("NO HAY NOTAS TODAVÍA");
            }
            else
            {
                float notaMaxima = notas[0];
                string estudiante = nombres[0];
                for (int i = 1; i < contador; i++)
                {
                    if (notas[i] > notaMaxima)
                    {
                        notaMaxima = notas[i];
                        estudiante = nombres[i];
                    }
                }

                string textoResultado = $"Estudiante: {estudiante}\n" +
                                        $"Nota: {notaMaxima}\n" +
                                        "================================\n";

                Console.WriteLine(textoResultado);
            }

            return Operaciones.getEntero("Presione 1: Volver\n" + 
                "================================\n", texto);
        }

        public static int NotaMasBaja()
        {
            Console.Clear();

            string texto = "================================\n" +
                          "Nota mas baja\n" +
                          "================================\n";

            if (contador == 0)
            {
                Console.WriteLine("NO HAY NOTAS REGISTRADAS TODAVÍA");
            }
            else
            {
                float notaMinima = notas[0];
                string estudiante = nombres[0];

                for (int i = 1; i < contador; i++)
                {
                    if (notas[i] < notaMinima)
                    {
                        notaMinima = notas[i];
                        estudiante = nombres[i];
                    }
                }

                texto += $"Estudiante: {estudiante}\n" +
                         $"Nota: {notaMinima}\n" +
                         "================================\n";
                Console.WriteLine(texto);
            }

            return Operaciones.getEntero("Presione 1 para volver\n" +
                "================================\n", texto);
        }


        public static int ListaDeEstudiantes()
        {
            Console.Clear();

            string texto = "================================\n" +
                          "Lista de Estudiantes\n" +
                          "================================\n";

            if (contador == 0)
            {
                texto += "NO HAY NOTAS REGISTRADAS TODAVÍA";
            }
            else
            {
                for (int i = 0; i < contador; i++)
                {
                    texto += $"{nombres[i]} {notas[i]}\n";
                }
            }

            texto += "================================\n";
            Console.Write(texto);

            return Operaciones.getEntero("Presione 1 para volver\n" + 
                "================================\n", texto);
        }
    }
}
    

