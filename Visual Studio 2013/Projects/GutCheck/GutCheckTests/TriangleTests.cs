using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GutCheck;
using NUnit.Framework;

namespace GutCheckTests
{
    public class TriangleTests
    {
        [TestCase(1, 1, 1, "equilateral")]
        [TestCase(1, 2, 2, "isosceles")]
        [TestCase(1, 2, 3, "scalene")]
        public void Triangles(int a, int b, int c, string expected)
        {
            string result = TriangleTypes.Triangles(a, b, c);
            
            Assert.AreEqual(expected, result);
        }
    }
}
