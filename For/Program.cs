using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
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

            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine(friends[i]);
            }
        }
    }
}
