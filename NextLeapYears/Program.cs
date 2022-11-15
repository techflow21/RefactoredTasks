using System;
namespace NextLeapYears
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeapYears();
            Console.ReadLine();
        }

        public static void LeapYears()
        {
            //DateTime thisYear = DateTime.Now;
            Console.WriteLine("Enter any year to get next 20 leap years");
            string ?current_yr = Console.ReadLine();
            int current_year = Convert.ToInt32(current_yr);
            int count = 0;

            while (count < 20)
            {
                if (((current_year % 4 == 0) && (current_year % 100 != 0)) || (current_year % 400 == 0))
                {
                    Console.WriteLine(current_year + " is a leap year");
                    count++;
                }
                current_year++;
            }

        }
    }
}