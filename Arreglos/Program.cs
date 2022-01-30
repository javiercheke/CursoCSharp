using System;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            // creacion de arreglo 
            string[] friends = new string[8] {
            "Pancho",
            "Carlos",
            "Oswaldo",
            "Daniel",
            "Juan",
            "Andres",
            "Vanesa",
            "Mario"

            };

            friends[0] = "Javier";
            friends[5] = "Maria";

            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);
            Console.WriteLine(friends[3]);
            Console.WriteLine(friends[4]);
            Console.WriteLine(friends[5]);
            Console.WriteLine(friends[6]);
            Console.WriteLine(friends[7]);

            int[] numeros = new int[4]//Arreglo de numeros
            {
                1,2,3,4

            };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            
        }
    }
}
