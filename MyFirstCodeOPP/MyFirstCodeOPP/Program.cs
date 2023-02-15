using System;

namespace MyFirstCodeOPP
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Write a year");
                string year = Console.ReadLine();

                Console.WriteLine("Write a month");
                string month = Console.ReadLine();

                Console.WriteLine("Write a day");
                string day = Console.ReadLine();

                var dateObject = new Date(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day));
                Console.WriteLine(dateObject);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
