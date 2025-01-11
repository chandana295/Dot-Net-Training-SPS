using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    internal class _18thQuestion
    {
        static void Main()
        {
            // Prompt the user to enter the first word
            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine();

            // Prompt the user to enter the second word
            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine();

            // Compare the two words
            if (word1.Equals(word2))
            {
                Console.WriteLine("The words are the same.");
            }
            else
            {
                Console.WriteLine("The words are different.");
            }
        }
    }
}
