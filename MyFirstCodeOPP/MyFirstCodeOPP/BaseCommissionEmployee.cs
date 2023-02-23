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
            return base.GetValuesToPay() + Base;
        }

        public override string ToString() 
        {
            return $"{base.ToString()} \n\t " +
                $"Salary Base:............................. {Base:C2} \n\t " +
                $"Commission Profit:....................... {base.GetValuesToPay():C2}";
        }
        #endregion
    }
}
