namespace SalaryCalculatorApp
{
    partial class EmployeeSalaryCalculatorUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.showSalary_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.houseRentTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.medicalAlncTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(150, 13);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.employeeNameTextBox.TabIndex = 1;
            // 
            // showSalary_Button
            // 
            this.showSalary_Button.Location = new System.Drawing.Point(150, 178);
            this.showSalary_Button.Name = "showSalary_Button";
            this.showSalary_Button.Size = new System.Drawing.Size(105, 23);
            this.showSalary_Button.TabIndex = 2;
            this.showSalary_Button.Text = "Show me Salary";
            this.showSalary_Button.UseVisualStyleBackColor = true;
            this.showSalary_Button.Click += new System.EventHandler(this.showSalary_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Salary";
            // 
            // employeeSalaryTextBox
            // 
            this.employeeSalaryTextBox.Location = new System.Drawing.Point(150, 53);
            this.employeeSalaryTextBox.Name = "employeeSalaryTextBox";
            this.employeeSalaryTextBox.Size = new System.Drawing.Size(141, 20);
            this.employeeSalaryTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "House Rent";
            // 
            // houseRentTextBox
            // 
            this.houseRentTextBox.Location = new System.Drawing.Point(150, 90);
            this.houseRentTextBox.Name = "houseRentTextBox";
            this.houseRentTextBox.Size = new System.Drawing.Size(141, 20);
            this.houseRentTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Medical Allowance";
            // 
            // medicalAlncTextBox
            // 
            this.medicalAlncTextBox.Location = new System.Drawing.Point(150, 130);
            this.medicalAlncTextBox.Name = "medicalAlncTextBox";
            this.medicalAlncTextBox.Size = new System.Drawing.Size(141, 20);
            this.medicalAlncTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "% of basic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "% of basic";
            // 
            // EmployeeSalaryCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 269);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.showSalary_Button);
            this.Controls.Add(this.medicalAlncTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.houseRentTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.employeeSalaryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeSalaryCalculatorUI";
            this.Text = "EmployeeSalaryCalculatorUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.Button showSalary_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeeSalaryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox houseRentTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox medicalAlncTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

