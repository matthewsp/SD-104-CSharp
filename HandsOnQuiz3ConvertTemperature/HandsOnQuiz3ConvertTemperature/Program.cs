using System;

namespace HandsOnQuiz3ConvertTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Celcius/Faherenheit Converter");
            Console.WriteLine("Enter F if you would like to convert Celcius to Faherenheit.");
            Console.WriteLine("Enter C if you would like to Convert Fahrenheit to Celcius.");
            Conversion conversion = new Conversion();
            string choice = Console.ReadLine();
            switch ( choice.ToUpper())
                {
                case "F":
                    conversion.ConvertTemp("CtoF");
                    break;
                case "C":
                    conversion.ConvertTemp("FtoC");
                    break;
                default: break;
                }

        }
        
    }
}
