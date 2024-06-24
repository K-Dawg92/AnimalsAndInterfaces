using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndInterfaces
{
    internal class Turtle : IQuadrupeds
    {
        public void move()
        {
            Console.WriteLine("Freshwater turtles have more flexible legs and longer toes with webbing, giving them thrust in the water.");
        }
        public void eat()
        {
            Console.WriteLine("Aquatic turtles and land turtles have different preferences when it comes to how they eat their food. Aquatic turtles only eat underwater, so you'll need to place food in their water tank. ");
        }
    }
}
