using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Shape : HomeScreen
    {
        static void Run()
        {
            Rectangle r = new Rectangle();
            r.AcceptParameters();
            r.Display();
            Console.ReadLine();

            Triangle t = new Triangle();
            t.AcceptParameters();
            t.Display();
            Console.ReadLine();

            Circle c = new Circle();
            c.AcceptParameters();
            c.Display();
            Console.ReadLine();

        }
    }
}
