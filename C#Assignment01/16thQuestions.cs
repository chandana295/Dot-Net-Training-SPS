using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    internal class _16thQuestions
    {
        static void Main()
        {
            // Prompt the user to enter a word
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            // Calculate the length of the word
            int length = word.Length;

            // Display the length of the word
            Console.WriteLine($"The length of the word \"{word}\" is: {length}");
        }
    }
}
