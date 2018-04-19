using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Which index of the Fibonacci sequence you want the value for?");
            int index = Int32.Parse(Console.ReadLine());
            int prevnumber = 1;
            int prevprevnumber = 0;
            int sum = 0;
            for (int i = 0; i <= index; i++)
            {
                if(i == 0)
                {
                    prevprevnumber = 0;
                    prevnumber = 0;
                }
                if (i == 1)
                {
                    prevnumber = 1;
                    prevprevnumber = 0;
                }
                if (i == 2)
                {
                    prevnumber = 1;
                    prevprevnumber = 0;
                }
                sum = prevnumber + prevprevnumber;
                prevprevnumber = prevnumber;
                prevnumber = sum;
            }
            Console.WriteLine(sum);
            Console.Read();
        }
    }
}
