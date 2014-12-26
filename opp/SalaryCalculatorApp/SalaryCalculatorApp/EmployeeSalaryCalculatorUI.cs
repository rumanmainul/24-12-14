using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class EmployeeSalaryCalculatorUI : Form
    {
        public EmployeeSalaryCalculatorUI()
        {
            InitializeComponent();
        }
        Employee aEmployee = new Employee();
        private void showSalary_Button_Click(object sender, EventArgs e)
        {
            string employeeName = employeeNameTextBox.Text;
            double employeeSalary = Convert.ToDouble(employeeSalaryTextBox.Text);
            double houseRent = Convert.ToDouble(houseRentTextBox.Text);
            double medicalAllowance = Convert.ToDouble(medicalAlncTextBox.Text);
            double totalSalary = aEmployee.ShowTotalSalary(employeeName, employeeSalary, houseRent, medicalAllowance);
            MessageBox.Show(aEmployee.EmployeeName + " your total salary is " + totalSalary);
        }
    }
}
