using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program 8");
            Console.WriteLine("Please input a sentence");
            string sentence = Console.ReadLine(); 
            int spaceCount = 0; 

            foreach (char c in sentence)
            {
                if (c == ' ')
                {
                    spaceCount++;
                }
            }
            Console.WriteLine($"In \"{sentence}\" there are {spaceCount} spaces");
            Console.WriteLine("Now input a whole number");
            string number = Console.ReadLine();
            int sum = 0;
            foreach (char d in number)
            {
                sum += (int)Char.GetNumericValue(d);
            }
            Console.WriteLine($"The sum of the individual digits of your number \"{number}\" is {sum}");
        }   
    }
}