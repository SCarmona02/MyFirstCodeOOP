using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOPP
{
    public class SalaryEmployee : Employee
    {
        #region Properties

        public decimal Salary { get; set; }

        #endregion

        #region Methods
        public override decimal GetValuesToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()} \n\t " +
                $"Value to Pay:............................{GetValuesToPay():C2}";
        }

        #endregion
    }
}
