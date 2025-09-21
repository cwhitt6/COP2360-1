public class Dogs
{
    // Fields
    public string Name;
    public string Breed;
    public int Age;

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
