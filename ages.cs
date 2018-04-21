using System;

namespace Arrays
{
    class ages
    {
        static void Main(string[] args)
        {
            int[] ages = { 80, 18, 65, 75 };
            for (int i =0; i < ages.Length; i++)
            {
                if( ages[i] >= 65)
                {
                Console.WriteLine(i + 1);
                }

            }
            Console.Read();
        }
    }
}
