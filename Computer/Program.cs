using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Program
    {
        static void Main(string[] args)
        {
           Laptop auralapto = new Laptop();


            Desktop linettedesktop = new Desktop();
            Desktop linettedesktop2 = new Desktop(true);
            Desktop linettedesktop3 = new Desktop(true , 400);


            auralapto.open();
            auralapto.turnON();
            Console.ReadLine();

            
        }
    }
}
