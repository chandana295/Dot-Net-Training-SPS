using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    internal class _17thQuestion
    {
        static void Main()
        {
            // Prompt the user to enter a word
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            // Reverse the word
            string reversedWord = ReverseString(word);

            // Display the reversed word
            Console.WriteLine($"The reverse of the word \"{word}\" is: \"{reversedWord}\"");
        }

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray(); // Convert the string to a character array
            Array.Reverse(charArray);              // Reverse the array
            return new string(charArray);          // Convert the reversed array back to a string
        }
    }
}
