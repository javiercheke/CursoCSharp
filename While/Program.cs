using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i<10)
            {
                Console.WriteLine("Iteracionde i "+ i);
                i++;
            }

            int j = 0;

            while (j < 100)
            {
                if (j > 5)
                    break;

                Console.WriteLine("Iteracionde j " + j);
                j++;
            }

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
            int index = 0;
            while (index < friends.Length)
            {
                Console.WriteLine(friends[index]);
                index++;
            }
            bool run = false;
            do
            {
                Console.WriteLine("Entro una vez y ya");

            } while (run);
        }
    }
}
