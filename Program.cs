/*******************************************************************
 * Name: Anthony Seldon
 * Date: November 8, 2026
 * Assignment: SDC220 Week 5 PA - Inheritance & Overriding
 *
 * Main application class.
 * This program demonstrates inheritance and method overriding
 * by creating Animal and Cat objects, displaying their properties,
 * updating their properties, and displaying them again.
 *******************************************************************/

using System;

public class App
{
    static void Main(string[] args)
    {
        // Print the assignment header
        Console.WriteLine(
            "Anthony Seldon - Week 5 PA - Inheritance & Overriding\n");

        // Create an Animal and a Cat
        Animal animal = new Animal("Roo", 2);
        Cat cat = new Cat("Fluffy", 4, "meow");

        // Display the original properties
        animal.PrintAnimal();
        cat.PrintAnimal();

        // Update the Animal and Cat properties
        animal.Name = "Flipper";
        animal.Legs = 0;

        cat.Name = "Garfield";
        cat.Legs = 4;
        cat.Sound = "I'm HUNGRY";

        // Display the updated properties
        animal.PrintAnimal();
        cat.PrintAnimal();
    }
}