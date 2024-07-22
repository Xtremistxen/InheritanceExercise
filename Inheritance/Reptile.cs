using System;

namespace Inheritance;

// This is the Reptile CHILDREN class which will inherit from Animals class
public class Reptile : Animal
{

    // This will include 4 basic members
    public bool HasScales { get; set; }
    public string ScaleColor { get; set; }
    public bool IsVenomous { get; set; }
    public string Habitat { get; set; }

    // Method to display the Reptile detail/traits
    public void ReptileInfo()
    {
        
        Console.WriteLine($"Has Scales: {HasScales}");
        Console.WriteLine($"Scale Color: {ScaleColor}");
        Console.WriteLine($"Is Venomous: {IsVenomous}");
        Console.WriteLine($"Habitat: {Habitat}");

    }
}
     
