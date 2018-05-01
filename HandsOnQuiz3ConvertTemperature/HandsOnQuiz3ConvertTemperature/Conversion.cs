using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnQuiz3ConvertTemperature
{
    class Conversion
    {
        public void ConvertTemp(string convertTo)
        {
            float temperature;
            if (convertTo == "CtoF")
            {
                Console.WriteLine("How many degrees Celsius?");
                while(! float.TryParse(Console.ReadLine(),out temperature))
                {
                    Console.WriteLine("Not a valid number. Please try again.");
                }
                temperature = temperature * 9 / 5 + 32;
                Console.WriteLine(temperature + "degrees Fahrenheit");
            }
            if(convertTo == "FtoC")
            {
                Console.WriteLine("How many degrees Fahrenheit?");
                while (!float.TryParse(Console.ReadLine(), out temperature))
                {
                    Console.WriteLine("Not a valid number. Please try again.");
                }
                temperature = (temperature - 32) * 5 / 9;
                Console.WriteLine(temperature + "degrees Celsius");
            }
        }
    }
}
