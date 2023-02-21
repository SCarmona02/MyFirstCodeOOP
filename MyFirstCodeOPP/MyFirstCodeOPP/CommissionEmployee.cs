using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOPP
{
    internal class CommissionEmployee : Employee
    {
        #region Properties
        public float CommissionPercentage { get; set; }
        public decimal Sales { get; set; }
        #endregion

        #region Methods
        public override decimal GetValuesToPay()
        {
            return Sales * (decimal)ConvertPercentage(CommissionPercentage);
        }

        public override string ToString()
        {
            return $"{base.ToString()} \n\t " +
                $"Commission Percentage:................... {ConvertPercentage(CommissionPercentage):P2} \n\t " +
                $"Sales:................................... {Sales:C2} \n\t " +
                $"Value to Pay:............................ {GetValuesToPay():C2}";
        }

        public float ConvertPercentage(float commissionPercentage)
        {
            return (commissionPercentage/100); 
        }
        #endregion
    }
}
