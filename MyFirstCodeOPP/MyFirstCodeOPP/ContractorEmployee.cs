using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOPP
{
    public class ContractorEmployee : Employee
    {
        #region Properties
        public float Hours { get; set; }
        public decimal HoursValue { get; set; }
        #endregion

        #region Methods
        public override decimal GetValuesToPay()
        {
            return ((decimal)Hours * HoursValue);
        }
        public override string ToString() 
        {
            return $"{base.ToString()} \n\t " +
                $"Number of hours:..........................{Hours} \n\t " +
                $"Value per hour:...........................{HoursValue:C2} \n\t " +
                $"Value to pay:.............................{GetValuesToPay():C2}";
        }

        #endregion
    }
}
