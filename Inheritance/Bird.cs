using System;

namespace Inheritance;

// This is the Bird CHILDREN class which will inherit from Animals class
public class Bird : Animal
{
        
    // Looked up Basic members for Birds Properties
        public bool CanFly { get; set; }
        public string BeakType { get; set; }
        public double WingSpan { get; set; }
        public string FavoriteFood { get; set; }

        // Method to display the bird specific details/traits
            public void BirdInfo()
        {
            
            Console.WriteLine($"Can Fly: {CanFly}");
            Console.WriteLine($"BeakType: {BeakType}");
            Console.WriteLine($"WingSpan: {WingSpan} Feet");
            Console.WriteLine($"Favorite Food: {FavoriteFood}");
        }
    }
