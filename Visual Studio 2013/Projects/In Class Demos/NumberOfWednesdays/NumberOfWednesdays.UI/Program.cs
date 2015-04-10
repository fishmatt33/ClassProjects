using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfWednesdays.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a date");
            string dateEntered = Console.ReadLine();
            
            DateTime user = DateTime.Parse(dateEntered);
            Console.WriteLine("Please enter a number");
            string number = Console.ReadLine();

            int usernum = int.Parse(number);
            int counter = 0;

            bool done = false;
            do
            {
                if (user.DayOfWeek == DayOfWeek.Wednesday)
                {
                    Console.WriteLine(user);
                    counter ++;
                }

                if (counter == usernum)
                {
                    done = true;
                }
                user = user.AddDays(1);

            } 
            while (done == false);
            Console.ReadLine();


        }
    }
}
