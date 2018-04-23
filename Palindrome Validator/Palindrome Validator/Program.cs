using System;

namespace Palindrome_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            // take user input
            // loops through each letter
            // check if backwards position is the same as the current possition
            //if loop finishes you havea palindrome
            //if letter is different then it is not (use a bool)
            
            //word[length-1] -count
            Console.WriteLine("Enter a word.");
            string word = Console.ReadLine().ToLower;
            bool isPalindrome = true;
            for (int x = 0; x < word.Length; x++)
            {
                if (word[x] != word[word.Length - 1 - x])
                {
                    isPalindrome = false;
                }
            }
            if (isPalindrome== false)
            {
                Console.Write ("Is no a palindrome")
            }
            else
               Console.WriteLine("Is a palindrome")
                    Console.Read();
        }
    }
}
