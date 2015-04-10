using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock.UI
{
    class AlarmClock
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the time for your alarm");
            string dateEntered = Console.ReadLine();
            DateTime user = DateTime.Parse(dateEntered);

            DateTime d1;
            d1 = DateTime.Now;

            TimeSpan diff = user.Subtract(d1);

            Console.WriteLine("The current time is " + d1 + ".  Your alarm will go off in" + diff);
            Console.ReadLine();
        }
        
        
    }
}
