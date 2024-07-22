using System;

namespace Inheritance;

public class Animal
{
    //This will be the PARENT class, looked up basic Animal kingdom... added one more for practice
    public string AnimalName { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }
    public bool IsWild { get; set; }
    //public bool IsExtinct { get; set; }
    
    // This will be the Method for common details on the Animal
    public void AnimalInfo()
    {
        Console.WriteLine($"Name: {AnimalName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"IsWild {IsWild}");
        //Console.WriteLine($"Extinct: {IsExtinct}");
    }
}