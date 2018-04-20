using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPHDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AddACat("MiuMiu");
            AddADog("WangWang");

            Console.WriteLine("Dogs:");
            Print(GetDogs());
            Console.WriteLine("Cats:");
            Print(GetCats());
            Console.WriteLine("All:");
            Print(GetAnimals());

            Console.ReadLine();
        }

        private static void AddACat(string name)
        {
            using (var context = new TphContext())
            {
                Animal cat = new Cat()
                {
                    Name = name,
                    Type = "CAT"
                };

                context.Animals.Add(cat);
                context.SaveChanges();
            }
        }

        private static void AddADog(string name)
        {
            using (var context = new TphContext())
            {
                Animal dog = new Dog()
                {
                    Name = name,
                    Type = "DOG"
                };

                context.Animals.Add(dog);
                context.SaveChanges();
            }
        }

        private static List<Animal> GetAnimals()
        {
            using (var context = new TphContext())
            {
                return context.Animals.ToList();
            }
        }

        private static List<Animal> GetDogs()
        {
            using (var context = new TphContext())
            {
                return context.Animals.OfType<Dog>().Cast<Animal>().ToList();
            }
        }

        private static List<Animal> GetCats()
        {
            using (var context = new TphContext())
            {
                return context.Animals.OfType<Cat>().Cast<Animal>().ToList();
            }
        }

        private static void Print(List<Animal> animals)
        {
            animals.ForEach(a => Console.WriteLine(a.Name));
        }
    }
}
