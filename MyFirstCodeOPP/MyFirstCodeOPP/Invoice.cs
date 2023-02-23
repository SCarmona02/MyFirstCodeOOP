using MyFirstCodeOPP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOPP
{
    internal class Invoice : IPay
    {
        #region Properties
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Quantity { get; set; }
        #endregion

        #region Methods
        public decimal GetValuesToPay()
        {
            return Price * (decimal)Quantity;
        }
        public override string ToString()
        {
            return $"Id: {Id} - Description: {Description}\n\t" +
                $"Quantity...........{Quantity}\n\t" +
                $"price..............{Price:C2}\n\t" +
                $"Invoice Value......{GetValuesToPay():C2}";
        }

        #endregion
    }
}
