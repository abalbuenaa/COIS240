using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            persona thePerson1;
            persona theperson2;
            theperson2 = new persona();
            thePerson1 = new persona();
            thePerson1.name = "Anita Tolson";
            theperson2.name = "Linda Eady";
            thePerson1.gender = "female";
            thePerson1.dateOfBirth = "8/27/1990";
            thePerson1.age = "25";


          Console.WriteLine("My coworker name is {0}, her sex is {1} She born on {2} she is {3}  years old.", thePerson1.name, thePerson1.gender, thePerson1.dateOfBirth, thePerson1.age);
            Console.WriteLine ("{1} say hello my friend to {0}", theperson2.name, thePerson1.name);
            Console.ReadLine();


        }
    }
}
