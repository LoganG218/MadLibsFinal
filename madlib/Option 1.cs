using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MadLibOne
{
    static public string getMadLibOne()
    {


        Console.WriteLine("Enter your characters name: ");
        string name = Console.ReadLine();

        Console.WriteLine("\nEnter an adjective: ");
        string adjective1 = Console.ReadLine();

        Console.WriteLine("\nEnter a forecast: ");
        string forecast = Console.ReadLine();

        Console.WriteLine("\nEnter an object: ");
        string object1 = Console.ReadLine();

        Console.WriteLine("\nEnter another name: ");
        string name2 = Console.ReadLine();

        Console.WriteLine("\nEnter a location: ");
        string location = Console.ReadLine();

        Console.WriteLine("\nEnter an article of clothing or outfit: ");
        string clothing = Console.ReadLine();

        Console.WriteLine("\nEnter an action verb: ");
        string AVerb = Console.ReadLine();

        Console.WriteLine("\nEnter one more adjective: ");
        string adjective3 = Console.ReadLine();

        Console.WriteLine("\nEnter a body part: ");
        string part = Console.ReadLine();




        Console.WriteLine("This is your Madlib!:\n");

        string story = $"{name} woke up on a {adjective1} and {forecast} day. They went downstairs to grab some {object1}, when he got a call from his friend, {name2}. {name2} said ‘{name}! Meet me at the {location} in 10 minutes!’ and hung up. {name} left their house immediately, to meet {name2} there. When he arrived he found {name2} wearing only a {clothing} and holding flowers and he said ‘{name}! I’m {AVerb} a girl here in 30 seconds. What do I say to her?’. {name} replied ‘Say that they look very {adjective3}’ He smiled, shook my {part} and the girl arrived.";



        return story;

    }
}