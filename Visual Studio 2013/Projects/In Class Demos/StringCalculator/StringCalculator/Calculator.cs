using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers))
            {
                return 0;

            }


            else
            {
                var digits = numbers.Split(',');
                int sum = 0;
                foreach (var numberStr in digits)
                {
                    int parsed2;
                    if (int.TryParse(numberStr, out parsed2))
                    {
                        sum += parsed2;
                    }

                }
                return sum;
            }

            else
            {
                return 0;
            }

        }

    }
}
