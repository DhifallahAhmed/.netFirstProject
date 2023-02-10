﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public Staff()
        {
        }

        public Staff(DateTime employementDate, string function, int salary)
        {
            EmployementDate = employementDate;
            Function = function;
            Salary = salary;
        }

        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }
        public int Salary { get; set; }
        public override string ToString()
        {
            return $"EmployementDate: {EmployementDate}, Function: {Function}, Salary: {Salary}";
        }
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am a Staff Member");
        }
    }
}
