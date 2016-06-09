using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet planet1 = new Planet();
            planet1.name = "Venus";
             
           
            Planet planet2 = new Planet();
            planet2.name = "Angelito";

        }
        /// <summary>
        /// Describe the planet is rotating
        /// </summary>
        public void rotate()
        {
            Console.WriteLine("The planet {0} is rotating very fast!");
        }
    }
}