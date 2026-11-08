/*******************************************************************
 * Name: Anthony Seldon
 * Date: November 8, 2026
 * Assignment: SDC220 Week 5 PA - Inheritance & Overriding
 *
 * Cat class.
 * This is the derived class that inherits from Animal.
 * It adds a Sound property and overrides PrintAnimal() to
 * display the cat's name, number of legs, and sound.
 *******************************************************************/

public class Cat : Animal
{
    // Class property
    public string Sound { get; set; }

    // Constructor calls the base class constructor
    public Cat(string name, int legs, string sound) : base(name, legs)
    {
        Sound = sound;
    }

    // Override the base class PrintAnimal method
    public override void PrintAnimal()
    {
        Console.WriteLine(
            "The Cat's name is {0}, it has {1} legs and is making a {2} sound.",
            Name, Legs, Sound);
    }
}