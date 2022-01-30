using System;

namespace SecuenciaIfElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            bool areYouHungry = true;
            bool youHaveMoney = true;

            if (areYouHungry && youHaveMoney && IsOpenRestaurant("Lonches juan",11))
            {
                Console.WriteLine("Ve a comer");

            }
            else
            {
                Console.WriteLine("No comes");
            }

        }

        static bool IsOpenRestaurant(string name, int hour = 0)
        {

            if (name == "Lonches pepe" && hour > 8 && hour < 23)
            {
                return true;
            }
            else if(name == "Restaurant 24 houras")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
