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

            switch (choice)
            {
                case "A":
                    Console.WriteLine("How many miles?: ");
                        double milesA = Int32.Parse(Console.ReadLine());
                        double kmA = milesA * 1.6;
                        Console.WriteLine(milesA + " miles = " + kmA + " kilometers");
                        break;
                case "B":
                    Console.WriteLine("How many inches?: ");
                    double inchesB = Int32.Parse(Console.ReadLine());
                    double cmB = inchesB * 2.54;
                    Console.WriteLine(inchesB + " inches = " + cmB + " centimeters");
                    break;
                case "C":
                    Console.WriteLine("How many pounds?");
                    double lbC = Int32.Parse(Console.ReadLine());
                    double kgC = lbC * 0.45359237;
                    Console.WriteLine(lbC + " pounds = " + kgC + " kg");
                    break;
                case "E":
                    Console.WriteLine("How many centimeters?");
                    double cmE = Int32.Parse(Console.ReadLine());
                    double inchesE = 0.39 * cmE;
                    Console.WriteLine(cmE + " centimeters = " + inchesE + " inches");
                    break;
                case "F":
                    Console.WriteLine("How many kilograms?");
                    double kgF = Int32.Parse(Console.ReadLine());
                    double lbF = 2.2 * kgF;
                    Console.WriteLine(kgF + " kilograms = " + lbF + " pounds");
                    break;


            }

            //continues here
        }
    }
}
