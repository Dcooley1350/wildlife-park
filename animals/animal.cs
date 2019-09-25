using System;
using System.Collections.Generic;

namespace Wildlife.Animals
{
    class Animal
    {
        private string _name;
        private string _species;
        private string _continent;
        private string _type;

        public Animal(string name, string species, string continent, string type)
        {
            _name = name;
            _species = species;
            _continent = continent;
            _type = type;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string newName)
        {
            _name = newName;
        }

        public string GetSpecies()
        {
            return _species;
        }

        public string GetContinent()
        {
            return _continent;
        }

        public string GetType()
        {
            return _type;
        }

        public static void MainSearch(List<Animal> listA)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("**Welcome to the Epicodus Wildlife Park! Please select one of the below options:**");
            Console.WriteLine("1. View animals in park.");
            Console.WriteLine("2. Add an animal to the park.");
            Console.WriteLine("3. Release all animals from park.");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Animal.AnimalSearch(listA);
            }
            else if (userInput == "2")
            {
                Animal.AddAnimal(listA);
            }
            else if (userInput == "3")
            {
                Animal.ReleaseAnimals(listA);
            }
            else
            {
                Console.WriteLine("Pick a valid number.");
            }
        }

        public static void AnimalSearch(List<Animal> listA)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Search animals by:");
            Console.WriteLine("1. Name");
            Console.WriteLine("2. Species");
            Console.WriteLine("3. Continent of Origin");
            Console.WriteLine("4. Class");
            Console.WriteLine("5. View all");
            string userSearch = Console.ReadLine();

            if (userSearch == "1")
            {
                Console.WriteLine("Enter a name to search for:");
                string userName = Console.ReadLine();

                foreach (Animal furryfriend in listA)
                {
                    if (furryfriend.GetName() == userName)
                    {
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Name: " + furryfriend.GetName());
                        Console.WriteLine("Species: " + furryfriend.GetSpecies());
                        Console.WriteLine("Continent of Origin: " + furryfriend.GetContinent());
                        Console.WriteLine("Class: " + furryfriend.GetType());
                    }
                }
                Animal.MainSearch(listA);
            }
            else if (userSearch == "2")
            {
                Console.WriteLine("Enter a species to search for:");
                string userSpecies = Console.ReadLine();

                foreach (Animal furryfriend in listA)
                {
                    if (furryfriend.GetSpecies() == userSpecies)
                    {
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Name: " + furryfriend.GetName());
                        Console.WriteLine("Species: " + furryfriend.GetSpecies());
                        Console.WriteLine("Continent of Origin: " + furryfriend.GetContinent());
                        Console.WriteLine("Class: " + furryfriend.GetType());
                    }
                }
                Animal.MainSearch(listA);
            }
            else if (userSearch == "3")
            {
                Console.WriteLine("Enter a continent to search for:");
                string userContinent = Console.ReadLine();

                foreach (Animal furryfriend in listA)
                {
                    if (furryfriend.GetContinent() == userContinent)
                    {
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Name: " + furryfriend.GetName());
                        Console.WriteLine("Species: " + furryfriend.GetSpecies());
                        Console.WriteLine("Continent of Origin: " + furryfriend.GetContinent());
                        Console.WriteLine("Class: " + furryfriend.GetType());
                    }
                }
                Animal.MainSearch(listA);
            }
            else if (userSearch == "4")
            {
                Console.WriteLine("Enter an animal class to search for: [ex. Mammal or Reptile]");
                string userType = Console.ReadLine();

                foreach (Animal furryfriend in listA)
                {
                    if (furryfriend.GetType() == userType)
                    {
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Name: " + furryfriend.GetName());
                        Console.WriteLine("Species: " + furryfriend.GetSpecies());
                        Console.WriteLine("Continent of Origin: " + furryfriend.GetContinent());
                        Console.WriteLine("Class: " + furryfriend.GetType());
                    }
                }
                Animal.MainSearch(listA);
            }
            else if (userSearch == "5")
            {
                foreach (Animal furryfriend in listA)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Name: " + furryfriend.GetName());
                    Console.WriteLine("Species: " + furryfriend.GetSpecies());
                    Console.WriteLine("Continent of Origin: " + furryfriend.GetContinent());
                    Console.WriteLine("Class: " + furryfriend.GetType());
                }
                Animal.MainSearch(listA);
            }
            else
            {
                Console.WriteLine("Please enter a valid number!");
                Animal.MainSearch(listA);
            }
        }

        public static void AddAnimal(List<Animal> listC)
        {
            Console.WriteLine("Enter your new Animal's Name:");
            string newAnimalName = Console.ReadLine();
            Console.WriteLine("Enter your new Animal's Species:");
            string newAnimalSpecies = Console.ReadLine();
            Console.WriteLine("Enter your new Animal's Continent of Origin:");
            string newAnimalContinent = Console.ReadLine();
            Console.WriteLine("Enter your new Animal's Class Type:");
            string newAnimalType = Console.ReadLine();

            Animal newAnimal = new Animal(newAnimalName, newAnimalSpecies, newAnimalContinent, newAnimalType);
            listC.Add(newAnimal);

            Animal.MainSearch(listC);
        }

        public static void ReleaseAnimals(List<Animal> listB)
        {
            Console.WriteLine("**All Animals have been released. They regard you as their hero now!**");
            Console.WriteLine(listB.Count);
            
            // listB.RemoveAll(animals);

            // foreach (Animal furryfriend in listB)
            // {
            //   listB.Remove(furryfriend);
            // }

            // for (int i = listB.Count; i > 1; i--)
            // {
            // Console.WriteLine("AAHHHHHH");
            // listB.RemoveAt(i);
            // Console.WriteLine(listB.Count);
            // }

            listB.Clear();

            Animal.MainSearch(listB);
        }

    }
}