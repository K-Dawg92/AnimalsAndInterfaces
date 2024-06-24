using System.Security.Cryptography.X509Certificates;

namespace AnimalsAndInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sheep sheep = new Sheep();
            Lion lion = new Lion();
            Crocodile crocodile = new Crocodile();
            Cow cow = new Cow();
            Elephant Dumbo = new Elephant();
            Turtle franklin = new Turtle();
            Human akwasi = new Human();
            Monkey cesar = new Monkey();
            
            sheep.flee();
            crocodile.hunt();
            lion.hunt();
            cesar.eat();
            akwasi.eat();
            franklin.move();
            


            PredatorsAreOut(lion);
            PredatorsAreOut(crocodile);

            cow.flee();

        }

        static void PredatorsAreOut(IPredator predator)
        {
            predator.hunt();
        }
        static void UnitedAreTrash(IPrey edouard)
        {
            edouard.hide();
        }
    }
}
