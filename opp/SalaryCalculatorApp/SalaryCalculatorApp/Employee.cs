using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Employee
    {
        private string employeeName;
        private double employeeSalary { set; get; }
        private double houseRent { set; get; }
        private double medicalAllowance { set; get; }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public double ShowTotalSalary(string employeeName, double employeeSalary, double houseRent, double medicalAllowance)
        {
            this.EmployeeName = employeeName;
            this.employeeSalary = employeeSalary;
            this.houseRent = houseRent;
            this.medicalAllowance = medicalAllowance;
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
