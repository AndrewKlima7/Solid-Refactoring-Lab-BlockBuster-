using System;
using System.Collections.Generic;

namespace Solid_Refactory_lab__Blockbuster_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again == true)
            {
                BlockBusterVideo bv = new BlockBusterVideo();
                bv.PrintAllMovies();
                bv.Checkout();
                again = GoAgain();
            }
        }

        public static bool GoAgain()
        {
            Console.Write("Would you like to watch another movie? Y/N");
            string input = Console.ReadLine();

            if (input.ToUpper() == "Y" || input.ToUpper() == "YES")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                return true;
            }
            else if (input.ToUpper() == "N" || input.ToUpper() == "NO")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Must input a valid response.");
                return GoAgain();
            }
        }
    }
}
