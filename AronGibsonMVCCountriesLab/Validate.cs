using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AronGibsonMVCCountriesLab
{
    class Validate
    {
        public static int ValidateIndex(int length) {
            do
            {
                try
                {
                    Console.WriteLine("Enter country index");
                    int index = int.Parse(Console.ReadLine());
                    if (index >= 1)
                        if (index <= length)
                            return index - 1;
                    Console.WriteLine($"Must enter a number between 1 and {length}");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Must enter a number between 1 and {length}");
                }
            } while (true) ;
        }

        public static string ValidateAgain() {
            do {
                Console.WriteLine("Learn about another country?");
                string again = Console.ReadLine().Trim().ToLower();
                if (again == "y")
                    return again;
                else if (again == "n")
                    return again;
                Console.WriteLine("Must enter y or n");
            } while (true);
        }

    }
}
