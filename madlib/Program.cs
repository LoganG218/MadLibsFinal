
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

            
            Console.WriteLine("Welcome to MADLibs! Please select a story option, 1, 2, 3 or 4 to quit.");
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

                    case "4":
                        Console.WriteLine("Thank you for playing!");
                        repeat = false;
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