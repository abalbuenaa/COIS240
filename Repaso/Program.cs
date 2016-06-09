using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            /**/
            double alto;
            double ancho;
            double area;

            alto = 5;
            ancho = 10;
            area = add(alto, ancho);
            Console.WriteLine(area);
            Console.ReadLine();
            

            /*
            double pi;
            double radio;
            double Area;

            pi = 3.14;
            radio = 4;
            Area = add(pi, radio);
            Console.WriteLine(Area);
            Console.ReadLine(); */




        }
        static double add(double v1, double v2)
        {
            double product = v1 + v2;
            return product;
           

        }

    }
}
