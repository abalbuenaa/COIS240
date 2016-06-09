using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Computer
    {
        private string _model;

        public string model
        {
            get { return _model; }
            set { _model = value; }
        }
        public void turnOff ()
        {

        }
        public void turnON ()
        {
            Console.WriteLine("The computer is now turned on!");
        }

    }// final del model
   

}
