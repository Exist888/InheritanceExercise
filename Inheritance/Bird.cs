using System;
using System.Collections.Generic;
using System.Net;

namespace Inheritance;

public class Bird : Animal
{
    // Inheriting Class - Members that belong to Class Bird
    
    // Field
    public string _colorOfFeathers;
    public string _levelOfGracefulness;
    
    // Properties
    public string WingSpanSmMedLg { get; set; }
    public string NoiseItMakes { get; set; }
    public string BirdSpecies { get; set; }

    public void BirdInterp()
    {
        Console.WriteLine($"\n" +
                      $"Can you guess the animal of the day?\n" +
                      $"It's feathers are {_colorOfFeathers}.\n" +
                      $"It's level of gracefulness can be described as\n" +
                      $"{_levelOfGracefulness}.\n" +
                      $"It moves by {HowItMoves}.\n" +
                      $"It's wingspan is {WingSpanSmMedLg}.\n" +
                      $"It has {NumberOfLegs} legs.\n" +
                      $"It breathes {HowItBreathes}.\n" +
                      $"It eats {Diet}\n" +
                      $"It also makes a {NoiseItMakes} noise.\n" +
                      $"\n");

        string userGuesses = Console.ReadLine().ToLower();
        //string caseAgnosticUserGuess = userGuesses.ToLower();

        while (userGuesses != $"{BirdSpecies}".ToLower())
        {
            Console.WriteLine("Great try, but not quite there. Guess again!");
            userGuesses = Console.ReadLine().ToLower();
        }
        
        if (userGuesses == $"{BirdSpecies}".ToLower())
        {
            Console.WriteLine($"You guessed correctly! The animal of the day\n" +
                              $"is a {BirdSpecies}");
        }
    }
}