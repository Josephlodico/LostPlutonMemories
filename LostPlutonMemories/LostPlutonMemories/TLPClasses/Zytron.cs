using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LostPlutonMemories.TLPClasses
{
    public static class Zytron
    {
        public static void Speak(string line, int delayMs = 700)
        {
            Console.WriteLine($"\n[Zytron] {line}");
            Thread.Sleep(delayMs);
        }

        public static void NarrateMemory(Memory memory)
        {
            Speak($"Accessing Memory {memory.Id}...");
            Speak($"\"{memory.Title}\"");
            Console.WriteLine($"\n--- MEMORY {memory.Id}: {memory.Title} ---");
            Console.WriteLine(memory.Description);
            Console.WriteLine("==================================================================================");
            Speak("Do you understand the Memory now... or are you still missing pieces?");
        }
    }
}
