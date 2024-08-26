using System;
using System.Collections.Generic;
using System.Net;

namespace Inheritance;

public class Reptile : Animal
{
    // Inheriting Class - 4 Members that belong to Class Reptile
    
    // Field
    public string _teethOrNo;
    public string _whatStandsOut;
    
    //
    public string ColorOfScales { get; set; }
    public string PreferredHabitat { get; set; }
    public string Size { get; set; }
    public string ReptileSpecies { get; set; }
    
    public void ReptileInterp()
    {
        Console.WriteLine($"\n" +
                      $"Now get extra credit by guessing tomorrow's animal of the day:\n" +
                      $"It's has {_teethOrNo}.\n" +
                      $"It's scales can be colored\n" +
                      $"{ColorOfScales}.\n" +
                      $"It moves by {HowItMoves}.\n" +
                      $"It has {NumberOfLegs} legs.\n" +
                      $"It eats {Diet}\n" +
                      $"It breathes {HowItBreathes}.\n" +
                      $"It lives in {PreferredHabitat}.\n" +
                      $"Its size can be {Size}.\n" +
                      $"It has a {_whatStandsOut}" +
                      $"\n");

        string userGuesses = Console.ReadLine().ToLower();
        //string caseAgnosticUserGuess = userGuesses.ToLower();

        while (userGuesses != $"{ReptileSpecies}".ToLower())
        {
            Console.WriteLine("Great try, but not quite there. Guess again!");
            userGuesses = Console.ReadLine().ToLower();
        }
        
        if (userGuesses == $"{ReptileSpecies}".ToLower())
        {
            Console.WriteLine($"You guessed correctly! Tomorrow's animal of the day\n" +
                              $"is a {ReptileSpecies}");
        }
    }
}