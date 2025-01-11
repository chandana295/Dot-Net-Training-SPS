using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    internal class _19thQuestion
    {
        static void Main()
        {
            // Prompt the user to enter a word
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            // Check if the word is a palindrome
            if (IsPalindrome(word))
            {
                Console.WriteLine($"The word \"{word}\" is a palindrome.");
            }
            else
            {
                Console.WriteLine($"The word \"{word}\" is not a palindrome.");
            }
        }

        // Method to check if the word is a palindrome
        static bool IsPalindrome(string word)
        {
            // Convert the word to lowercase for case-insensitive comparison
            word = word.ToLower();

            // Reverse the word and compare it with the original
            char[] wordArray = word.ToCharArray();
            Array.Reverse(wordArray);
            string reversedWord = new string(wordArray);

            return word == reversedWord; // Return true if the word is the same as its reverse
        }
    }
}
