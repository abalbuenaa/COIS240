using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Desktop:Computer

    {
        private bool _hasSpeakers;
        private int _harddriveCapacity;
        public bool hasSpeakers


        {
            get { return _hasSpeakers; }
            set { _hasSpeakers = value; }
        }

        /// <summary>
        /// ammount of harddrive
        /// </summary>
        public int harddriveCapacity
        {
            get { return _harddriveCapacity; }
            set { _harddriveCapacity = value; }
        }
        // final del harddrive
        public void assemble()
        {

        }
        public Desktop()
        {
            Console.WriteLine("Your desktop was created!");


        }
       // constructor
       public Desktop (bool hasSpeakers)
        {
            _hasSpeakers = hasSpeakers;
            Console.WriteLine("Has speaker!");

        }

       public  Desktop(bool value1,int value2 )
        {
            _hasSpeakers = value1;
            _harddriveCapacity = value2;

        }
            


    }
    }

