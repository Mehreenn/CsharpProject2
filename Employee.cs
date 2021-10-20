using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_COMP123_02
{
    class Employee
    {
        private int employeeUserId;
        private string firstName;
        private string lastName;
        private double baseSalary;
        private double grossSales;
        private double commissionRate;


        public int EmployeeUserId { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double BaseSalary { get; set; }
        public double GrossSales { get; set; }
        public double CommissionRate { get; set; }



        public double Earnings()
        {
            return this.CommissionRate * this.GrossSales + this.BaseSalary;
        }

        public Employee()
        {
            this.EmployeeUserId = 0;
            this.FirstName = "";
            this.LastName = "";
            this.BaseSalary = 3000.00;
            this.CommissionRate = 0.3;
            this.GrossSales = 0;
        }

        public Employee(int employeeUserId, string firstName, double baseSalary)
        {
            this.EmployeeUserId = employeeUserId;
            this.FirstName = firstName;
            this.BaseSalary = baseSalary;
        }

        public override string ToString()
        {
            return $"\n {"First Name",20}: {this.FirstName,30} \n {"Last Name",20}: {this.LastName,30} \n {"ID:",20} {this.EmployeeUserId,30} \n {"Base Salary:",20} {this.BaseSalary,30:C} \n {"Gross Sales:",20} {this.GrossSales,30:C} \n {"Commission Rate:",20} {this.CommissionRate,30} \n {"Earnings:",20} {this.Earnings(),30:C}";

        }



    }
}
