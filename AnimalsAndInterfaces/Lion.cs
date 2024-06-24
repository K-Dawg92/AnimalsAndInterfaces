using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndInterfaces
{
    internal class Lion : IPredator
    {
        public void detect()
        {
            Console.WriteLine("The Lion detected Pumba");
        }
        public void encounter()
        {
            Console.WriteLine("The Lion encounters Pumba");
        }
        public void hunt()
        {
            Console.WriteLine("The Lion hunted Pumba");
        }
        public void capture()
        {
            Console.WriteLine("The Lion captured Pumba and fed him to the clan");
        }

    }
}
