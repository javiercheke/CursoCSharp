using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Show();
            Suma(3,3);
            Suma(a, b);
            int m = Multiplica(5, 5);
            Console.WriteLine(m);

        }

        static void Show()
        {
            //Esta funcion es void por lo que regresa nada 

            Console.WriteLine("Hola, soy un texto");
        }

        static void Suma (int num1, int num2)
        {
            //esta funcion recibe para parametros pero no entrega nada
            int num3 = num1 + num2;
            Console.WriteLine(num3);

        }

        static int Multiplica(int num1, int num2)
        {
            //esta funcion si regresa algo
            
            return num1 * num2;

        }
    }
}
