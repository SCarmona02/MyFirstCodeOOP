using System;

namespace MyFirstCodeOPP
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine("Write a year");
                //string year = Console.ReadLine();

                //Console.WriteLine("Write a month");
                //string month = Console.ReadLine();

                //Console.WriteLine("Write a day");
                //string day = Console.ReadLine();

                //var dateObject = new Date(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day));
                //Console.WriteLine(dateObject);

                Console.WriteLine("*******Testing lastes implementation***************");

                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id = 1,
                    FirstName = "Maria",
                    LastName = "Posada",
                    BirthDate = new Date(1950,2,5),
                    HiringDate = new Date(2022,12,31),
                    IsActive = true,
                    Salary = 200000.34M
                };

                Console.WriteLine(salaryEmployee);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
