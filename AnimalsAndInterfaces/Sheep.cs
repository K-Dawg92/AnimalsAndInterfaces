using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndInterfaces
{
    internal class Sheep : IPrey
    {
        public void flee()
        {
            Console.WriteLine("The Sheep runs away");
        }
        public void hide()
        {
            Console.WriteLine("The sheep hide from the bad bad wolf");
        }
        public void camouflage()
        {
            Console.WriteLine("Alibaba the black sheep used it's camouflage skill to escape the badass wolf");
        }
    }
}
