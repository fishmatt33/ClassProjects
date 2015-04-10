using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequenceInClass.UI
{
    class Program
    {
        private void Main()
        {
            Console.WriteLine(GetFibonacci(50));
            Method2(50);
        }

        //public long GetFibonacci(int x)
        //    {
        //        long[] results = new long[x];
        //        results[0] = 1;
        //        results[1] = 1;
        //        for (int i = 2; 1 < x; i++)
        //        {
        //            long current = results[i - 1] + results[i - 2];
        //            results[i] = current;
        //        }
        //        return results[x - 1];
        //    }

        //}

        public void Method2(int x)
        {
            long n = 0;
            long n1 = 1;
            long n2 = 1;

            for (int i = 2; i < x; i++)
            {
                n = n1 + n2;
                n2 = n1;
                n1 = n;
            }
            Console.WriteLine(n);
        }
    }
}
