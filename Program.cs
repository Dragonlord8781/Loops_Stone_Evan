using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project 8");
            string sentence = "In 9 days I'll be able to hunt Mizutsune and Zoh Shia again.";
            int spaceCount = 0; 

            foreach (char c in sentence)
            {
                if (c == ' ')
                {
                    spaceCount++;
                }
            }
            Console.WriteLine($"In the sentence \"{sentence}\" there are {spaceCount} spaces");
        }
    }
}