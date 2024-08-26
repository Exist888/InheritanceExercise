using System;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common
            
            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var duck = new Bird()
            {
                _colorOfFeathers = "white, bronze, gray, and green",
                _levelOfGracefulness = "moderate to slightly awkward",
                Diet = "small fish, seeds, aquatic plants, and insects",
                HowItBreathes = "through the nostrils on its beak",
                HowItMoves = "waddling while on land, flapping its flippers\n" +
                             "and then coasting like a tugboat while in water,\n" +
                             "and flying up to 80km per hour.",
                NoiseItMakes = "quack",
                NumberOfLegs = 2,
                WingSpanSmMedLg = "Medium/Large",
                BirdSpecies = "duck"
            };
            
            duck.BirdInterp();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */

            var turtle = new Reptile()
            {
                _teethOrNo = "no teeth",
                ColorOfScales = "olive green, greenish-brown, reddish-brown, yellow, black, and/or gray",
                Diet = "vegetables, fish, insects, greens, worms, and snails",
                HowItBreathes = "on land with its nostrils, and in water using cloaca, which work similarly to gills",
                HowItMoves = "waddling slowly on land, and swimming slowly in water",
                NumberOfLegs = 4,
                PreferredHabitat = "aquatic habitats like ponds, rivers, lakes, bays, and lagoons",
                Size = "4 inches to 8 feet long",
                _whatStandsOut = "hard shell on its back to protect itself",
                ReptileSpecies = "turtle"
            };
            
            turtle.ReptileInterp();
        }
    }
}
