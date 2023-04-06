
using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            var repeat = true;
            while(repeat)
            {

            
            Console.WriteLine("Welcome to MADLibs! Please select an option, 1, 2, or 3.");
            var input = Console.ReadLine();
            string Story = "";
            
            
            
                switch (input)
                {
                    case "1":
                        Story = MadLibOne.getMadLibOne();


                        break;

                    case "2":
                        Story = MadLibTwo.getMadLibTwo();

                        break;

                    case "3":
                        Story = MadLibThree.getMadLibThree();

                        break;



                    default:
                        Console.WriteLine("Unknown input");
                        break;
                }

                MadLibTwo.saveBets(Story);
            }
        }
    }
}