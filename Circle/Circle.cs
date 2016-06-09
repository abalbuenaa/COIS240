using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        public double radius;
        public double area;

        public double calculateArea()
        {
            area = Math.PI * radius * radius;
            return area;

        }
            
    }
}
