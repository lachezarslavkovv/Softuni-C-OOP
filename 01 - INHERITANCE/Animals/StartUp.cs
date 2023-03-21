using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                List<Animal> animals = new List<Animal>();

                string inputAnimal = Console.ReadLine();
                while (inputAnimal != "Beast!")
                {
                    string[] animalInffo = Console.ReadLine().Split();
                    string name = animalInffo[0];
                    int age = int.Parse(animalInffo[1]);
                    string gender = animalInffo[2];

                    if (age < 0)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    

                    else if (inputAnimal == "Cat")
                    {
                        Cat cat = new Cat(name, age, gender);
                        animals.Add(cat);
                    }
                    else if (inputAnimal == "Dog")
                    {
                        Dog dog = new Dog(name, age, gender);
                        animals.Add(dog);
                    }
                    else if (inputAnimal == "Frog")
                    {
                        Frog frog = new Frog(name, age, gender);
                        animals.Add(frog);
                    }
                    else if (inputAnimal == "Kitten")
                    {
                        Kitten kitten = new Kitten(name, age);
                        animals.Add(kitten);
                    }
                    else
                    {
                        Tomcat tomcat = new Tomcat(name, age);
                        animals.Add(tomcat);
                    }


                    inputAnimal = Console.ReadLine();
                }

                foreach (Animal animal in animals)
                {
                    Console.WriteLine(animal.GetType().Name);
                    Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                    Console.WriteLine(animal.ProduceSound());
                }
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message); ;
            }
        }
    }
}
