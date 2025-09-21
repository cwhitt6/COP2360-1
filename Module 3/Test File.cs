using System;

namespace COP2360_Whitt;

public class Dogs
{
    // Properties (nullable-aware, default initializers to satisfy nullable enabled)
    public string Name { get; set; } = string.Empty;
    public string Breed { get; set; } = string.Empty;
    public int Age { get; set; }

    // Constructor
    public Dogs(string name, string breed, int age)
    {
        Name = name;
        Breed = breed;
        Age = age;
    }

    // Method to display dog information
    public void Bark()
    {
        Console.WriteLine($"Name: {Name}, says: Woof!");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Breed: {Breed}, Age: {Age}");
    }
}
