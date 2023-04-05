using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MadLibTwo
{
    static public string getMadLibTwo()
    {


        Console.WriteLine("Enter your characters name: ");
        string name = Console.ReadLine();

        Console.WriteLine("\nEnter a celebrity: ");
        string celebrity = Console.ReadLine();

        Console.WriteLine("\nEnter an adjective: ");
        string adjective1 = Console.ReadLine();

        Console.WriteLine("\nEnter a game: ");
        string game = Console.ReadLine();

        Console.WriteLine("\nEnter a number: ");
        string number = Console.ReadLine();

        Console.WriteLine("\nEnter an explitive: ");
        string explitive= Console.ReadLine();

        Console.WriteLine("\nEnter an item: ");
        string item = Console.ReadLine();

        Console.WriteLine("\nEnter a restaurant: ");
        string restaurant = Console.ReadLine();

        Console.WriteLine("\nEnter a facial expression: ");
        string expression = Console.ReadLine();





        Console.WriteLine("This is your Madlib!:\n");

        string story = $"One day {name} was walking down the street when he spotted 56th president, {celebrity}. They approached {name} and said “Son, you're looking mighty {adjective1}. How about a game of {game} to cheer you up!” {name} agreed to a few rounds, and they were on their way. In the end, {celebrity} lost by {number} points. “Aw {explitive}! Well, for beating me, here is an honorary {item}. With this you can get free {restaurant} on sundays!” Logan {expression} and walked away.";


        return story;

    }
    public static void saveBets(string story)
    {
        var path = @"C:\Users\Logan\Documents\coding\test1\file.txt";
        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.WriteLine(story);
        }
        string readText = File.ReadAllText(path);
        Console.WriteLine(readText);
    }
}