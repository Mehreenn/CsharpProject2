using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_COMP123_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(); //default employee
            Console.WriteLine(emp1);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(GetEmployee(111)); //custom employee

            Console.ReadKey();
        }

        static void GetEmployeeData(out string firstName, out string lastName, out double baseSalary, out double grossSales, out double commissionRate)
        {
            Console.Write("Enter First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            lastName = Console.ReadLine();


            Console.Write("Enter Gross Sales amount: ");
            grossSales = Convert.ToDouble(Console.ReadLine());
            while (grossSales <= 0)
            {

                Console.Write("Entry Invalid. Please enter valid Gross Sales amount:  ");
                grossSales = Convert.ToDouble(Console.ReadLine());
            }


            Console.Write("Enter Commission Rate: ");
            commissionRate = Convert.ToDouble(Console.ReadLine());


            while (commissionRate <= 0.2 || commissionRate > 1)
            {
                Console.Write("Entry Invalid. Please enter valid Commission Rate :");
                commissionRate = Convert.ToDouble(Console.ReadLine());

            }


            Console.Write("Enter Base Salary:  ");
            baseSalary = Convert.ToDouble(Console.ReadLine());

        }

        static Employee GetEmployee(int employeeUserId)
        {
            GetEmployeeData(out string firstName, out string lastName, out double baseSalary, out double grossSales, out double commissionRate);
            Employee employee = new Employee(employeeUserId, firstName, baseSalary);
            employee.LastName = lastName;
            employee.GrossSales = grossSales;
            employee.CommissionRate = commissionRate;
            return employee;
        }
    }

}


    

