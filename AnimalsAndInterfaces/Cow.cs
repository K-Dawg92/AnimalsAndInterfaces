using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndInterfaces
{
    internal class Cow : IPrey
    {
        public void camouflage()
        {
            Console.WriteLine("The fat cow saw the ennemi, used it's camouflage skill");
        }

        public void hide()
        {
            Console.WriteLine("The fat cow was able to hide from the hunter");
        }
        public void flee()
        {
            Console.WriteLine("The fat Cow was able to run");
        }
    }
}
