using System;

namespace initials
{
    class Program
    {
        public string GetInitials(string FirstName, string LastName)
        {
            string Initial = Char.ToUpper(FirstName[0]) + Char.ToUpper(LastName[0]);
            return Initial;
        }
        static void Main(string[] args)
        {
            
        }
        
    }
}
