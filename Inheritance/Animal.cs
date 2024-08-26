namespace Inheritance;

public class Animal
{
    //Parent Class - Give Class 4 Members that all animals have in common
    
    //Properties
    public int? NumberOfLegs { get; set; }  //Nullable to make sure we make room for fish.
    public string HowItBreathes { get; set; }
    public string HowItMoves { get; set; }
    public string Diet { get; set; }
}