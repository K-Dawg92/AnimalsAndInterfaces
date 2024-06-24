using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndInterfaces
{
    internal class Human : IBipeds
    {
        public void move()
        {
            Console.WriteLine("The human moved along the forest with his two feet");
        }
        public void eat() 
            { 
                Console.WriteLine("The human eats boths animals and plants which makes him an omnivore"); 
            }
    }
}
