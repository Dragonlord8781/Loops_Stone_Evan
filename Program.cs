using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Writes the program number into console, I've started to keep count of how many of these I've done
            Console.WriteLine("Program 8");

            //Writes a line asking for a sentence
            Console.WriteLine("Please input a sentence");
            //declares the string, sentence, and assignes it the inputted sentence
            string sentence = Console.ReadLine(); 
            //declares the intager spaceCount and sets it up for the loop with a 0
            int spaceCount = 0; 
            //starts loop to check each character in sentence
            foreach (char c in sentence)
            {
                // sets it where if the char is a space, spaceCount increases by one
                if (c == ' ')
                {
                    spaceCount++;
                }
            }
            //Write a string in console explaning the number of spaces within the inputted sentence
            Console.WriteLine($"In \"{sentence}\" there are {spaceCount} spaces");

            //Writes a line asking for a whole number
            Console.WriteLine("Now input a whole number");
            //declares string, number, and assignes it the inputted number
            string number = Console.ReadLine();
            //declares the intager sum, assigns it 0 to prepare it for the loope
            int sum = 0;
            //creates a loop to to check each digit in number
            foreach (char d in number)
            {
                //adds the numeric value of d(digit) to sume
                sum += (int)Char.GetNumericValue(d);
            }
            //Writes a line explain that the sum of each individual digit of the inputted number equals sum
            Console.WriteLine($"The sum of the individual digits of your number \"{number}\" is {sum}");
        }   
    }
}