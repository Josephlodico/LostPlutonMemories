using LostPlutonMemories.TLPClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//========================================================================================
//Name: Joseph Rogelio Lodico Suero
//Date: February 02, 2026
//Description: This is the main entry point for the Lost Pluton Memories application.
//========================================================================================
/*                          =========================================================================================
                            THELOSTPLUTON MEMORIES
========================================================================================== */
namespace LostPlutonMemories
{
    internal class TLPMain
    {
        static void Main(string[] args)
        {
            Console.Title = "TheLostPluton Memories - Zytron Terminal";

            //5 Memories that pluton has lost

            List<Memory> memories = new List<Memory>()
            {
                new Memory(1, "The First Maze","So... you managed to get lost. I was wondering how long it would take the mist to guide you here.You may not remember why you're here, Pluton... but i do."),
                new Memory(2, "The Second Maze","pending memory"),
                new Memory(3, "The Third Maze","pending memory"),
                new Memory(4, "The Fourth Maze","pending memory"),
                new Memory(5, "The Fifth Maze","pending memory")

            };

            Zytron.Speak("Welcome to TheLostPluton.");
            Zytron.Speak("I am Zytron. I hold what you forget");
            Zytron.Speak("Choose a Memory Fragment to recover (1-5). Type 'exit' to quit.");

            while (true)
            {
                Console.Write("\n Choose Memory (1-5) or 'exit': ");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (input == "exit")
                {
                    Zytron.Speak("Goodbye, Pluton. May your memories guide you.");
                    break;

                }

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 5)
                {
                    Console.WriteLine("==================================================================================");
                    Memory selected = memories.Find(m => m.Id == choice);
                    Zytron.NarrateMemory(selected);

                    Zytron.Speak("Pick another memory... if you dare.");
                }
                else
                {
                    Zytron.Speak("That input is invalid. Choose 1-5... or type 'exit'.");
                }
            }
        }
    }
}
