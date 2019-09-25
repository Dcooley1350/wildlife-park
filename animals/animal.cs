using System;

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


    public void AnimalSearch()
    {
      Console.WriteLine("----------------------");
      Console.WriteLine("1. View animals in park.");
      Console.WriteLine("2. Add an animal to the park.");
      Console.WriteLine("3. Release all animals from park.");
      string userInput = Console.ReadLine();
    }
  }
}