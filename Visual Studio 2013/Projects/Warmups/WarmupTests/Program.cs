using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleWarmup;

namespace WarmupTests
{
    class Testing
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine(StringWarmups.SkipSum(10, 11));
                Console.ReadLine();
            }
        }
    }
}
