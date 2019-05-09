using System;
using System.Collections.Generic;

namespace BreakOutSessionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can I have your age please?");


            var input = Console.ReadLine();


            int inputNumber;
            while (true)
            {
                // theres a bug somehwere around here! let's figure this bad boy out.
                if (!int.TryParse(input, out inputNumber))
                {
                    Console.WriteLine("please enter a valid input.");
                    continue;
                }

                if (inputNumber < 21)
                {
                    Console.WriteLine("Please enter an age GREATER then 21");
                    continue;
                }

                break;
            }

            Console.WriteLine("What do you want ot drink?");

            var drinkList = new List<string>();
            drinkList.Add("Old Fasion");
            drinkList.Add("PBR");
            drinkList.Add("Bloody Mary");
            

            while(true)
            {
                foreach (var drink in drinkList)
                {
                    Console.WriteLine(drink);
                }

                var userDrink = Console.ReadLine();
                var isDrinkEqual = false;
                foreach (var drink in drinkList)
                {
                    if (drink.Equals(userDrink, StringComparison.OrdinalIgnoreCase))
                    {
                        isDrinkEqual = true;
                    }
                }

                if (isDrinkEqual)
                {
                    break;
                }

                Console.WriteLine("drink does not exist in list.");
                Console.WriteLine("What do you want to drink?");
            }
        }
    }
}
