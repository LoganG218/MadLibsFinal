using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MadLibThree
{ 
    static public string getMadLibThree()
    { 


    Console.WriteLine("Enter a celebrities name: ");
    string name = Console.ReadLine();

    Console.WriteLine("\nEnter an adjective: ");
    string adjective1 = Console.ReadLine();

    Console.WriteLine("\nEnter a movie: ");
    string movie = Console.ReadLine();

    Console.WriteLine("\nEnter a restaurant: ");
    string restaurant = Console.ReadLine();

    Console.WriteLine("\nEnter a food: ");
    string foodOne = Console.ReadLine();

    Console.WriteLine("\nEnter another food: ");
    string foodTwo = Console.ReadLine();

    Console.WriteLine("\nEnter an emotion: ");
    string emotion = Console.ReadLine();

    Console.WriteLine("\nEnter a noun: ");
    string noun = Console.ReadLine();

    Console.WriteLine("\nEnter one more noun: ");
    string nounTwo = Console.ReadLine();

    Console.WriteLine("\nEnter an animal: ");
    string animal = Console.ReadLine();




    Console.WriteLine("This is your Madlib!:\n");

    string story = $"Micheal had a date planned with {name}, and they decided to watch the new hit {adjective1} movie, {movie}. After the movie, they went to {restaurant} and Micheal ordered  a {foodOne} while {name} ordered {foodTwo}. After conversing about the movie for a bit they both decided it made them feel {emotion}. Micheal also noted that the food tasted like {noun} and {name} said theirs tasted like {nounTwo}. They decided to leave and on their way home they came across a wild {animal} laying on the sidewalk. {name} announced that they hated the {animal} and Micheal decided that this relationship wasn’t going to work.";



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
