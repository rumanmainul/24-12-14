using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Employee
    {
        public string employeeName ;
        public double employeeSalary;
        public double houseRent;
        public double medicalAllowance;

        public double ShowTotalSalary()
        {
            double getHouseRent = GetPerchantageOfHouseRent();
            double getMedicalAllowance = GetPerchantageOfMedicalAllowance();
            double totalSalary = employeeSalary + getHouseRent + getMedicalAllowance;
            return totalSalary;
        }

        private double GetPerchantageOfMedicalAllowance()
        {
            return ((employeeSalary * medicalAllowance) / 100);
        }

        private double GetPerchantageOfHouseRent()
        {
            return ((employeeSalary * houseRent) / 100);
        }

      
    }
}
