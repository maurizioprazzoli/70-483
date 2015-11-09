using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceAndControvariance
{
    class Program
    {
        class Animal
        {
            public string Name { get; set; }
        }

        class Random { }

        class Cat : Animal
        {
            public Cat(string name)
            {
                this.Name = name;
            }
        }

        class Fish : Animal { }

        class Turtle : Animal { }
        static void Main(string[] args)
        {
           
            IEnumerable<Cat> cats = new List<Cat> { new Cat("Troublemaker") };
            PrintAnimals(cats);

            IEnumerable<Cat> cats1 = cats;
            PrintAnimals(cats);

            // 1. Declare new variable called animals capable of contains an array of Animal
            // 2. Instantiate new array of Cat of size 5 and copy it's address to animals variable
            // Now animal point to a array of Cats
            Animal[] animals = new Cat[5];
            // Instantiate new class of type Turtle, take this addess and put it into animals[0]
            // This throw exception at runtime since animals array point to array of cats.
//            animals[0] = new Turtle();

            //List<Animal> animalsList = new List<Cat>();
            //animalsList.Add(new Turtle());

            ControVariance c = new ControVariance();

        }

        static void PrintAnimals(IEnumerable<Animal> animals)
        {
            foreach (var animal in animals)
                Console.WriteLine(animal.Name);

            ((List<Cat>)animals).Add(new Cat("My Cat"));
        }
    }
}
