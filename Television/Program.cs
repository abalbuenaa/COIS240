using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Television
{
    class Program
    {
        static void Main(string[] args)
        {
            Television myTV1;
            myTV1 = new Television();
            myTV1.marca = "NEC";
            myTV1.modelo = "xyz";
            myTV1.tamanoPantalla = 52;

            Television myTV2 = new Television();
            myTV2.marca = "Toshiba";
            myTV2.modelo = "b328dx";
            myTV2.tamanoPantalla = 33;
            Console.WriteLine("Mi televisor {0} es lindo.", myTV1.marca);
            Console.WriteLine("Mi televisor {0} mide {1} pulgadas.", myTV1.marca, myTV1.tamanoPantalla);
            Console.WriteLine();
        }
    }
}
