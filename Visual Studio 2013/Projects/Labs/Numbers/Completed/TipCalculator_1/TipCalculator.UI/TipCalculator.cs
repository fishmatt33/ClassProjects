using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator.UI
{
    class TipCalculator
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter the bill total");
            string billTotal = Console.ReadLine();
            decimal newBill = decimal.Parse(billTotal);
            
            Console.WriteLine("enter the tip percentage");
            string tipP = Console.ReadLine();
            decimal newTip = decimal.Parse(tipP);

            decimal finalTip = (newTip/100)*newBill;
            
            decimal finalBill = finalTip + newBill;

            Console.WriteLine("Your tip amount is ${0}. Your new total is ${1}",  finalTip, finalBill);
            Console.ReadLine();
            //print out the new total 
        }
    }
}
