using System;
using System.Collections.Generic;
using System.Text;

namespace HW1
{
    class Conversion
    {
        double number;
        public Conversion()
        {
            number = 0;
        }
        public void GetUserInput()
        {
            number = Int32.Parse(Console.ReadLine());
        }
        public void ConvertMilesToKm()
        {
            GetUserInput();
            number = number * 1.6;
            Console.WriteLine(number + " kilometers");
        }
        public void ConvertInchesToCM()
        {
            GetUserInput();
            number = number * 2.54;
            Console.WriteLine(number + "centimeters");
        }
        public void ConvertPoundsToKG()
        {
            GetUserInput();
            number = number * 0.45359237;
            Console.WriteLine(number + "kilograms");
        }
        public void ConvertKMToMiles()
        {
            GetUserInput();
            number = number * 0.6214;
            Console.WriteLine(number + "miles");
        }
        public void ConvertCMToInches()
        {
            GetUserInput();
            number = number * 0.39;
            Console.WriteLine(number + "inches");
        }
        public void ConvertKGtoPounds()
        {
            GetUserInput();
            number = number * 2.2;
            Console.WriteLine(number + "pounds");
        }
    }
}  

