using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle1 = new Circle();
            myCircle1.radius = 2;
            myCircle1.calculateArea();
            Console.WriteLine("The radius is {0} and the area is {1} ", myCircle1.radius, myCircle1.area);
            Console.ReadLine();
        }
    }
}
