﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOPP
{
    public abstract class Employee
    {
        #region Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }
        #endregion

        #region Methods
        public abstract decimal GetValuesToPay();

        public override string ToString()
        {
            //return $"---EMPLOYEE---\n\t " +
            //    $"ID: {Id} \n\t " +
            //    $"First Name: {FirstName} \n\t " +
            //    $"Last Name: {LastName} \n\t " +
            //    $"Birth Date: {BirthDate} \n\t " +
            //    $"Hiring Date: {HiringDate} \n\t " +
            //    $"Is Active? {IsActive}";

            return String.Format("---EMPLOYEE---\n\t " +
                "ID: {0} \n\t " +
                "First Name: {1} \n\t " +
                "Last Name: {2} \n\t " +
                "Birth Date: {3} \n\t " +
                "Hiring Date: {4} \n\t " +
                "Is Active? {5}", Id, FirstName, LastName, BirthDate, HiringDate, IsActive);
        }
        #endregion
    }
}
