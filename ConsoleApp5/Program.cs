using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;

            Console.WriteLine("This program has multiple functionalities");
            Console.WriteLine("A to convert miles to KM, B to convert inches to CM, C to convert lbs to kg");
            Console.WriteLine("D to convert KM to miles, E to convert CM to inches, F to convert kg to lbs");
            Console.Write("Enter choice: ");
            choice = Console.ReadLine();
            Conversion conversion = new Conversion();
            switch (choice)
            {
                case "A":
                    Console.WriteLine("How many miles?: ");
                    conversion.ConvertMilesToKm();
                    break;
                case "B":
                    Console.WriteLine("How many inches?: ");
                   conversion.ConvertInchesToCM();
                    break;
                case "C":
                    Console.WriteLine("How many pounds?");
                    conversion.ConvertPoundsToKG();
                    break;
                case "D":
                    Console.WriteLine("How many kilometers?");
                    conversion.ConvertKMToMiles();
                    break;
                case "E":
                    Console.WriteLine("How many centimeters?");
                    conversion.ConvertCMToInches();
                    break;
                case "F":
                    Console.WriteLine("How many kilograms?");
                    conversion.ConvertKGtoPounds();
                    break;
            }
            Console.Read();
            
        }
    }
}
