using System;
using RectanguloPOO2022.Entidades;

namespace RectanguloPOO2022.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int ladoMayor, ladoMenor;
           
            bool errorObjeto = true;
            do
            { 
                bool error = true;

                ladoMayor = PedirInt("Ingrese el valor del lado mayor:");

                //do
                //{
                //    Console.Write("Ingrese el valor del lado mayor:");
                //    if (!int.TryParse(Console.ReadLine(),out ladoMayor))
                //    {
                //        Console.WriteLine("ERROR al ingresar un valor numérico");
                //    }
                //    else
                //    {
                //        error = false;
                //    }
                //} while (error);

                //error = true;
                //do
                //{
                //    Console.Write("Ingrese el valor del lado menor:");
                //    if (!int.TryParse(Console.ReadLine(), out ladoMenor))
                //    {
                //        Console.WriteLine("ERROR al ingresar un valor numérico");
                //    }
                //    else
                //    {
                //        error = false;
                //    }
                //} while (error);

                ladoMenor = PedirInt("Ingrese el valor del lado menor:");
                var rectangulo = new Rectangulo(ladoMayor, ladoMenor);
                if (rectangulo.Validar())
                {
                    Console.WriteLine($"Perímetro={rectangulo.GetPerimetro()}");
                    Console.WriteLine($"Superficie={rectangulo.GetSuperficie()}");
                    errorObjeto = false;
                }
                else
                {
                    Console.WriteLine("Error al validar el objeto... reintentar");
                }

            } while (errorObjeto);

            Console.ReadLine();
        }

        private static int PedirInt(string mensaje)
        {
            bool error = true;
            int valorInt;
            do
            {
                Console.Write($"{mensaje}");
                if (!int.TryParse(Console.ReadLine(),out valorInt))
                {
                    Console.WriteLine("Error al intentar ingresar un valor entero");
                }
                else
                {
                    error = false;
                }
            } while (error);

            return valorInt;
        }
    }
}
