using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            
            // This will be the object of the bird class
            var myBird = new Bird();
            
                myBird.AnimalName = "Red Tail Hawk";
                myBird.Age = 3;
                myBird.Color = "Brown and red";
                myBird.IsWild = true;
                myBird.CanFly = true;
                myBird.BeakType = "Hooked";
                myBird.WingSpan = 4.6;
                myBird.FavoriteFood = "Small mammals";
                
                Console.WriteLine("Animal info");
                myBird.AnimalInfo();
                
                Console.WriteLine("Bird Details");
                myBird.BirdInfo();

                
                var myReptile = new Reptile();

                myReptile.AnimalName = ("Komodo Dragon");
                myReptile.Age = 26;
                myReptile.Color = "Black";
                myReptile.IsWild = true;
                myReptile.HasScales = true;
                myReptile.ScaleColor = "Yellow-grey";
                myReptile.IsVenomous = true;
                myReptile.Habitat = "dry open grassland, savanna and tropical forest at low elevations";
                   
                Console.WriteLine("Animal info");
                myReptile.AnimalInfo();
                   
                Console.WriteLine("Reptile Details");
                myReptile.ReptileInfo();
                
        }
    }
}
