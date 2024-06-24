using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndInterfaces
{
    internal class Crocodile : IPredator
    {
            public void hunt()
        {
            Console.WriteLine("The crocodile is hunting it's prey");
        }
        public void encounter()
        {
            Console.WriteLine("It encounters the prey");
        }
        public void detect()
        {
            Console.WriteLine("After detecting the prey, it is being patient for the right move");
        }
        public void capture() 
        {
            Console.WriteLine("The crocodile finally caught it");

        }
    }
}
