using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Program
    {
        public class Animal
        {
            //Set properties for each animal
            public string AnimalType { get; set; }
            public string AnimalName { get; set; }

            public Animal() { }

            //Animal Constructor
            public Animal(string type, string name)
            {
                AnimalType = type;
                AnimalName = name;
            }
        }
        static void Main(string[] args)
        {
            //Add to Queue and print adopted animal by name
            Console.WriteLine("Animal Shelter");
            Console.WriteLine();
            Queue<Animal> shelter = new Queue<Animal>();
            shelter.Enqueue(new Animal("dog", "Cookie"));
            shelter.Enqueue(new Animal("cat", "Monster"));
            shelter.Enqueue(new Animal("dog", "Oscar"));
            shelter.Enqueue(new Animal("cat", "Elmo"));
            shelter.Enqueue(new Animal("cat", "BigBird"));
            shelter.Enqueue(new Animal("dog", "Kurmit"));
            Console.WriteLine(Adopt(shelter).AnimalName);
            Console.WriteLine();
            Console.WriteLine(Adopt(shelter, "dog").AnimalName);
            Console.Read();
        }

        public static Animal Adopt(Queue<Animal> shelter)
        {
            //Remove adopted animal from queue 
            return shelter.Dequeue();
        }

        public static Animal Adopt(Queue<Animal> shelter, string species)
        {
            //removes the last animal if the species == the animaltype
            if (species == shelter.Peek().AnimalType)
            {
                return shelter.Dequeue();
            }
            else
            {
                //else create a new instance of animal 
                Animal newAnimal = new Animal();
                Animal temp = shelter.Dequeue();
                string name = temp.AnimalName;
                shelter.Enqueue(temp);
                while (shelter.Peek().AnimalName != name)
                {
                    temp = shelter.Dequeue();
                    if (temp.AnimalType == species && newAnimal.AnimalName == null)
                    {
                        newAnimal = temp;
                    }
                    else
                    {
                        shelter.Enqueue(temp);
                    }
                }
                return newAnimal;
            }
        }
    }
}

