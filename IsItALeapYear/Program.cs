using System;

namespace IsItALeapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public Boolean IsItALeapYear(int a)
        {
           
            if ((a % 4) == 0)
            {
                return true;
            }
            else if ((a % 400) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
