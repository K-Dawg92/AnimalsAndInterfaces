using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndInterfaces
{
    internal class Elephant : IQuadrupeds
    {
        public void move()
            {
            Console.WriteLine("Elephants can move both forward and backward, but are incapable of trotting, jumping, or galloping. ");
            }
        public void eat()
            { 
                Console.WriteLine("Elephants eat grasses, leaves, shrubs, fruits and roots depending on the season and their habitat."); 
            }
    }
}
