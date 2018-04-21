using System;

namespace Lab_Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that takes a user input n times
            // Write it in an array
            // Loop through it, and display the array backwards
            int input;
            Console.WriteLine("Please enter how many numbers you want in your array.");
            while (!Int32.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("That's not a number. Enter a number.");
            }
            int[] UserArray = new int[input];
            for (int x = 0; x < UserArray.Length; x++)
            {
                Console.WriteLine("Enter the value for number " + (x + 1));
                while (!Int32.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("That's not a number. Enter a number.");
                }
                UserArray[x] = input;
            }
            for(int x = UserArray.Length - 1; x >= 0; x--)
            {
                if (x != 0)
                {
                    Console.Write(UserArray[x] + ", ");
                }
                else
                    Console.WriteLine(UserArray[x]);
            }
        }
    }
}
