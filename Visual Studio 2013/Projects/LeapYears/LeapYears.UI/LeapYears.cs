using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYears.UI
{
    class LeapYears
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first year");
            string firstYear = Console.ReadLine();
            int yearOne = int.Parse(firstYear);
            
            Console.WriteLine("Enter your second year");
            string secondYear = Console.ReadLine();
            int yearTwo = int.Parse(secondYear);

            for (int i = yearOne; i < yearTwo; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                    Console.WriteLine(i);
              
            }
            Console.ReadLine();
            
        }
    }
}
