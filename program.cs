using System;
using System.Collections.Generic;
using Wildlife.Animals;
namespace Wildlife
{
  public class Program
  {
    public static void Main()
    {
      Animal tiger = new Animal ("Tonya", "Tiger", "Asia", "Mammal");
      Animal hippo = new Animal ("Henry", "Hippo", "Africa", "Mammal");
      Animal elephant = new Animal ("Elizabeth", "Elephant", "Africa", "Mammal");
      Animal komodoDragon = new Animal ("Karl", "Komodo Dragon", "Asia", "Reptile");
      Animal lion = new Animal ("Leroy", "Lion", "Africa", "Mammal");
      Animal koala = new Animal ("Katherine", "Koala", "Australia", "Marsupial");
      Animal frog = new Animal ("Todd", "Giant Toad", "North America", "Amphibian");
      Animal osprey = new Animal ("Otis", "Osprey", "North America", "Bird");

      List<Animal> animals = new List<Animal> () {tiger, hippo, elephant, komodoDragon, lion, koala, 
      frog, osprey};

      Animal.MainSearch(animals);
      // Console.WriteLine("----------------------");
      // Console.WriteLine("Welcome to the Epicodus Wildlife Park! Please select one of the below options:");
      // Console.WriteLine("1. View animals in park.");
      // Console.WriteLine("2. Add an animal to the park.");
      // Console.WriteLine("3. Release all animals from park.");
      // string userInput = Console.ReadLine();

      // if (userInput == "1")
      // {
      //     Console.WriteLine("----------------------");
      //     Console.WriteLine("Search animals by:");
      //     Console.WriteLine("1. Name");
      //     Console.WriteLine("2. Species");
      //     Console.WriteLine("3. Continent of Origin");
      //     Console.WriteLine("4. Class");
      //     Console.WriteLine("5. View all");
      //     string userSearch = Console.ReadLine();

      //     if (userSearch == "1")
      //     {
      //         Console.WriteLine("Enter a name to search for:");
      //         string userName = Console.ReadLine();

      //         foreach (Animal furryfriend in Animals)
      //         {
      //             if (furryfriend.GetName() == userName)
      //             {
      //                 Console.WriteLine("----------------------");
      //                 Console.WriteLine("Name: " + furryfriend.GetName());
      //                 Console.WriteLine("Species: " + furryfriend.GetSpecies());
      //                 Console.WriteLine("Continent of Origin: " + furryfriend.GetContinent());
      //                 Console.WriteLine("Class: " + furryfriend.GetType());
      //             }
      //         }
      //       Main();
      //     }
      //     else if (userSearch == "2")
      //     {
      //         Console.WriteLine("Enter a species to search for:");
      //         string userSpecies = Console.ReadLine();

      //         foreach (Animal furryfriend in Animals)
      //         {
      //             if (furryfriend.GetSpecies() == userSpecies)
      //             {
      //                 Console.WriteLine("----------------------");
      //                 Console.WriteLine("Name: " + furryfriend.GetName());
      //                 Console.WriteLine("Species: " + furryfriend.GetSpecies());
      //                 Console.WriteLine("Continent of Origin: " + furryfriend.GetContinent());
      //                 Console.WriteLine("Class: " + furryfriend.GetType());
      //             }
      //         }
      //         Main();
      //     }
      //     else if (userSearch == "3")
      //     {
      //         Console.WriteLine("Enter a continent to search for:");
      //         string userContinent = Console.ReadLine();

      //         foreach (Animal furryfriend in Animals)
      //         {
      //             if (furryfriend.GetContinent() == userContinent)
      //             {
      //                 Console.WriteLine("----------------------");
      //                 Console.WriteLine("Name: " + furryfriend.GetName());
      //                 Console.WriteLine("Species: " + furryfriend.GetSpecies());
      //                 Console.WriteLine("Continent of Origin: " + furryfriend.GetContinent());
      //                 Console.WriteLine("Class: " + furryfriend.GetType());
      //             }
      //         }
      //          Main();
      //     }
      //     else if (userSearch == "4")
      //     {
      //         Console.WriteLine("Enter an animal class to search for: [ex. Mammal or Reptile]");
      //         string userType = Console.ReadLine();

      //         foreach (Animal furryfriend in Animals)
      //         {
      //             if (furryfriend.GetType() == userType)
      //             {
      //                 Console.WriteLine("----------------------");
      //                 Console.WriteLine("Name: " + furryfriend.GetName());
      //                 Console.WriteLine("Species: " + furryfriend.GetSpecies());
      //                 Console.WriteLine("Continent of Origin: " + furryfriend.GetContinent());
      //                 Console.WriteLine("Class: " + furryfriend.GetType());
      //             }
      //         }
      //         Main();
      //     }
      //     else if (userSearch == "5")
      //     {
      //         foreach (Animal furryfriend in Animals)
      //         {
      //             Console.WriteLine("----------------------");
      //             Console.WriteLine("Name: " + furryfriend.GetName());
      //             Console.WriteLine("Species: " + furryfriend.GetSpecies());
      //             Console.WriteLine("Continent of Origin: " + furryfriend.GetContinent());
      //             Console.WriteLine("Class: " + furryfriend.GetType());
      //         }
      //         Main();
      //     }
      //     else
      //     {
      //       Console.WriteLine("Please enter a valid number!");
      //       Main();
      //     }
      // }
      // else if (userInput == "2")
      // {
      //   Console.WriteLine("Enter your new Animal's Name:");
      //   string newAnimalName = Console.ReadLine();
      //   Console.WriteLine("Enter your new Animal's Species:");
      //   string newAnimalSpecies = Console.ReadLine();
      //   Console.WriteLine("Enter your new Animal's Continent of Origin:");
      //   string newAnimalContinent = Console.ReadLine();
      //   Console.WriteLine("Enter your new Animal's Class Type:");
      //   string newAnimalType = Console.ReadLine();

      //   Animal newAnimal = new Animal (newAnimalName, newAnimalSpecies, newAnimalContinent, newAnimalType);
      //   Animals.Add(newAnimal);
      //   Main();


    }
  }
}