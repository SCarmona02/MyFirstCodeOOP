using MyFirstCodeOPP.Helper;
using System;
using System.Collections.Generic;

namespace MyFirstCodeOPP
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine("*******************************");
                //Console.WriteLine("******* SALARY EMPLOYEE *******");
                //Console.WriteLine("*******************************");

                //Console.WriteLine("Write an Id");
                //int id = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a First Name");
                //string firstName = Console.ReadLine();

                //Console.WriteLine("Write a Last Name");
                //string lastName = Console.ReadLine();

                //Console.WriteLine("Insert Birth Date");

                //Console.WriteLine("Write a year");
                //int yearBirth = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a month");
                //int monthBirth = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a day");
                //int dayBirth = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Birth date: " + new Date(yearBirth, monthBirth, dayBirth));

                //Console.WriteLine("Insert Hiring Date");

                //Console.WriteLine("Write a year");
                //int yearHiring = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a month");
                //int monthHiring = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a day");
                //int dayHiring = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Hiring date: " + new Date(yearHiring, monthHiring, dayHiring));

                //Console.WriteLine("Is Active? (True, False)");
                //bool isActive = Convert.ToBoolean(Console.ReadLine());

                //Console.WriteLine("Write a salary");
                //decimal salary = Convert.ToDecimal(Console.ReadLine());

                ////var dateObject = new Date(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day));
                ////Console.WriteLine(dateObject);

                //Employee salaryEmployee = new SalaryEmployee()
                //{
                //    Id = id,
                //    FirstName = firstName,
                //    LastName = lastName,
                //    BirthDate = new Date(yearBirth, monthBirth, dayBirth),
                //    HiringDate = new Date(yearHiring, monthHiring, dayHiring),
                //    IsActive = isActive,
                //    Salary = salary
                //};

                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id = 1,
                    FirstName = "check",
                    LastName = "check",
                    BirthDate = new Date(2000, 2, 2),
                    HiringDate = new Date(2000, 2, 2),
                    IsActive = true,
                    Salary = (decimal)200000
                };

                //Console.WriteLine(salaryEmployee);

                //Console.WriteLine("*******************************");
                //Console.WriteLine("***** COMMISSION EMPLOYEE *****");
                //Console.WriteLine("*******************************");

                //Console.WriteLine("Write an Id");
                //id = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a First Name");
                //firstName = Console.ReadLine();

                //Console.WriteLine("Write a Last Name");
                //lastName = Console.ReadLine();

                //Console.WriteLine("Insert Birth Date");

                //Console.WriteLine("Write a year");
                //yearBirth = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a month");
                //monthBirth = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a day");
                //dayBirth = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Birth date: " + new Date(yearBirth, monthBirth, dayBirth));

                //Console.WriteLine("Insert Hiring Date");

                //Console.WriteLine("Write a year");
                //yearHiring = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a month");
                //monthHiring = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a day");
                //dayHiring = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Hiring date: " + new Date(yearHiring, monthHiring, dayHiring));

                //Console.WriteLine("Is Active? (True, False)");
                //isActive = Convert.ToBoolean(Console.ReadLine());

                //Console.WriteLine("Write a commission percentage");
                //float commissionPercentage = Convert.ToSingle(Console.ReadLine());

                //Console.WriteLine("Write a sales");
                //decimal sales = Convert.ToDecimal(Console.ReadLine());

                ////var dateObject = new Date(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day));
                ////Console.WriteLine(dateObject);

                //Employee commissionEmployee = new CommissionEmployee()
                //{
                //    Id = id,
                //    FirstName = firstName,
                //    LastName = lastName,
                //    BirthDate = new Date(yearBirth, monthBirth, dayBirth),
                //    HiringDate = new Date(yearHiring, monthHiring, dayHiring),
                //    IsActive = isActive,
                //    CommissionPercentage = commissionPercentage,
                //    Sales = sales
                //};

                Employee commissionEmployee = new CommissionEmployee()
                {
                    Id = 1,
                    FirstName = "check",
                    LastName = "check",
                    BirthDate = new Date(2000, 2, 2),
                    HiringDate = new Date(2000, 2, 2),
                    IsActive = true,
                    CommissionPercentage = Convert.ToSingle(10),
                    Sales = (decimal)100000
                };

                //Console.WriteLine(commissionEmployee);

                //Console.WriteLine("*******************************");
                //Console.WriteLine("***** CONTRACTOR EMPLOYEE *****");
                //Console.WriteLine("*******************************");

                //Console.WriteLine("Write an Id");
                //id = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a First Name");
                //firstName = Console.ReadLine();

                //Console.WriteLine("Write a Last Name");
                //lastName = Console.ReadLine();

                //Console.WriteLine("Insert Birth Date");

                //Console.WriteLine("Write a year");
                //yearBirth = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a month");
                //monthBirth = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a day");
                //dayBirth = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Birth date: " + new Date(yearBirth, monthBirth, dayBirth));

                //Console.WriteLine("Insert Hiring Date");

                //Console.WriteLine("Write a year");
                //yearHiring = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a month");
                //monthHiring = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a day");
                //dayHiring = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Hiring date: " + new Date(yearHiring, monthHiring, dayHiring));

                //Console.WriteLine("Is Active? (True, False)");
                //isActive = Convert.ToBoolean(Console.ReadLine());

                //Console.WriteLine("Write the number of hours");
                //int hours = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write the value per hour");
                //decimal hoursValue = Convert.ToDecimal(Console.ReadLine());

                ////var dateObject = new Date(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day));
                ////Console.WriteLine(dateObject);

                //Employee contractorEmployee = new ContractorEmployee()
                //{
                //    Id = id,
                //    FirstName = firstName,
                //    LastName = lastName,
                //    BirthDate = new Date(yearBirth, monthBirth, dayBirth),
                //    HiringDate = new Date(yearHiring, monthHiring, dayHiring),
                //    IsActive = isActive,
                //    Hours = hours,
                //    HoursValue = hoursValue
                //};

                Employee contractorEmployee = new ContractorEmployee()
                {
                    Id = 1,
                    FirstName = "check",
                    LastName = "check",
                    BirthDate = new Date(2000, 2, 2),
                    HiringDate = new Date(2000, 2, 2),
                    IsActive = true,
                    Hours = 50,
                    HoursValue = (decimal)1000000
                };

                //Console.WriteLine(contractorEmployee);

                //Console.WriteLine("********************************");
                //Console.WriteLine("** BASE & COMMISSION EMPLOYEE **");
                //Console.WriteLine("********************************");

                //Console.WriteLine("Write an Id");
                //id = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a First Name");
                //firstName = Console.ReadLine();

                //Console.WriteLine("Write a Last Name");
                //lastName = Console.ReadLine();

                //Console.WriteLine("Insert Birth Date");

                //Console.WriteLine("Write a year");
                //yearBirth = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a month");
                //monthBirth = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a day");
                //dayBirth = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Birth date: " + new Date(yearBirth, monthBirth, dayBirth));

                //Console.WriteLine("Insert Hiring Date");

                //Console.WriteLine("Write a year");
                //yearHiring = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a month");
                //monthHiring = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Write a day");
                //dayHiring = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Hiring date: " + new Date(yearHiring, monthHiring, dayHiring));

                //Console.WriteLine("Is Active? (True, False)");
                //isActive = Convert.ToBoolean(Console.ReadLine());

                //Console.WriteLine("Write a salary base");
                //decimal salaryBase = Convert.ToDecimal(Console.ReadLine());

                //Console.WriteLine("Write a commission percentage");
                //commissionPercentage = Convert.ToSingle(Console.ReadLine());

                //Console.WriteLine("Write a sales");
                //sales = Convert.ToDecimal(Console.ReadLine());

                ////var dateObject = new Date(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day));
                ////Console.WriteLine(dateObject);

                //Employee baseCommissionEmployee = new BaseCommissionEmployee()
                //{
                //    Id = id,
                //    FirstName = firstName,
                //    LastName = lastName,
                //    BirthDate = new Date(yearBirth, monthBirth, dayBirth),
                //    HiringDate = new Date(yearHiring, monthHiring, dayHiring),
                //    IsActive = isActive,
                //    CommissionPercentage = commissionPercentage,
                //    Sales = sales,
                //    Base = salaryBase
                //};

                Employee baseCommissionEmployee = new BaseCommissionEmployee()
                {
                    Id = 1,
                    FirstName = "check",
                    LastName = "check",
                    BirthDate = new Date(2000, 2, 2),
                    HiringDate = new Date(2000, 2, 2),
                    IsActive = true,
                    CommissionPercentage = Convert.ToSingle(10),
                    Sales = (decimal)20000000,
                    Base = (decimal)5000000
                };

                //Console.WriteLine(baseCommissionEmployee);

                EmployeeHelper employeeHelper = new EmployeeHelper(salaryEmployee, commissionEmployee, contractorEmployee, baseCommissionEmployee);

                Console.WriteLine($"Total Payroll:.................................... {employeeHelper.GetPayrollFromActiveEmployees():C2}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
