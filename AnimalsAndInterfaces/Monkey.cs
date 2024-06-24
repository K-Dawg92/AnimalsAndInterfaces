using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndInterfaces
{
    public class Monkey : IBipeds
    {
        public void eat()
        {
            Console.WriteLine("Monkeys are omnivores, they eat both meat and plants");
        }
        public void move()
        {
            Console.WriteLine("Monkeys move along the trees and walk on both feet");
        }
    }
    
        
    
}
