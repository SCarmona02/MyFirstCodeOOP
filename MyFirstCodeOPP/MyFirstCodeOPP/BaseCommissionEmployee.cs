using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOPP
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        #region Properties
        public decimal Base { get; set; }
        #endregion

        #region Methods
        public override decimal GetValuesToPay()
        {
            //return ((Sales * (decimal)ConvertPercentage(CommissionPercentage)) + Base);
            return base.GetValuesToPay() + Base;
        }

        public override string ToString() 
        {
            return $"{base.ToString()} \n\t " +
                $"Salary Base:..............................{Base:C2} \n\t " +
                $"Value to pay with base....................{GetValuesToPay():C2}";
        }
        #endregion
    }
}
