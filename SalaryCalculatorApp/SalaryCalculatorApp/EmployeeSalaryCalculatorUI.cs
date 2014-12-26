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
            aEmployee.employeeName = employeeNameTextBox.Text;
            aEmployee.employeeSalary = Convert.ToDouble(employeeSalaryTextBox.Text);
            aEmployee.houseRent = Convert.ToDouble(houseRentTextBox.Text);
            aEmployee.medicalAllowance = Convert.ToDouble(medicalAlncTextBox.Text);
            double totalSalary = aEmployee.ShowTotalSalary();
            MessageBox.Show(aEmployee.employeeName + " your total salary is " + totalSalary);
        }
    }
}
