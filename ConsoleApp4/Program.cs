using System;

namespace Lab3CalculateBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight;
            int height;
            Console.WriteLine("This program will calculate your body mass index.");
            Console.Write("What is your weight in pounds?: ");
            weight = Int32.Parse(Console.ReadLine());
            Console.Write("What is your height in inches?: ");
            height = Int32.Parse(Console.ReadLine());

            double BMI = (weight * 703) / ((height * height));


            if (BMI < 18.5)
            {
                Console.WriteLine("You are underweight. Go eat some cake.");
            }
           if ((BMI >= 18.5) && (BMI < 25)) 
            {
                Console.WriteLine("You're BMI is normal");
            }
          if ((BMI >= 25) && (BMI < 30)) 
            {
                Console.WriteLine("You are overweight. Cut the cookies man!");
            }
            if(BMI >= 30)
            {
                Console.WriteLine("Whoa! You are obese! Lose some weight!");
            }
            Console.Read();
        }
    }
}
