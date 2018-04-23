using System;

namespace SmallestLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int largestnumber;
            int smallestnumber;
            int currentnumber;
            Console.WriteLine("Please enter a number besides zero.");
            while (Int32.TryParse(Console.ReadLine(),out number) ==  false)
            {
                Console.WriteLine("That's not a number fool. Please enter a number.");
            }
            currentnumber = Int32.Parse(Console.ReadLine());
            smallestnumber = currentnumber;
            largestnumber = currentnumber;

            while (currentnumber != 0) 
            {
                if(currentnumber > largestnumber)
                {
                    largestnumber = currentnumber;
                }
                if (currentnumber < smallestnumber)
                {
                    smallestnumber = currentnumber;
                }
                Console.Write("Please enter another number or press 0 to quit.");
                while (Int32.TryParse(Console.ReadLine(), out number) == false)
                {
                    Console.Write("That's not a number fool. Please enter a number.");
                }
                currentnumber = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("smallest number = " + smallestnumber);
            Console.WriteLine("largest number = " + largestnumber);
            Console.Read();
        }
    }
}
