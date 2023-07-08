using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1Float
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a float: ");
            string input = Console.ReadLine();
            float result;
            if (float.TryParse(input, out result))
            {
                Console.WriteLine("Parsed float: " + result);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}
