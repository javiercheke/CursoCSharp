using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 7;

            switch (op)
            {
                case 1:
                    Console.WriteLine("seleccionaste el 1");
                    break;
                case 2:
                    Console.WriteLine("Seleccionaste el 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Seleccionaste la opcion 3 o 4");
                    break;
                case < 0:
                case > 100:
                    Console.WriteLine("Fuera de Rango");
                    break;
                case > 4 and < 10:
                    Console.WriteLine("Seleccionaste una opcion entre 4 y 10");
                    break;  



                default:
                    Console.WriteLine("Invalido");
                    break;
            }
        }
    }
}
