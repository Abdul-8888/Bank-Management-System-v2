using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Management_System.BL;
using Bank_Management_System.DL;

namespace Bank_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomerDL.loadCustomers();
            EmployeeDL.loadEmployees();
            BankDL.loadBank();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool flag = true;
            lblNotChosen.Hide();

            if (radManager.Checked)
            {
                Employee manager = EmployeeDL.getEmployee(txtUsername.Text, txtPassword.Text, flag);

                if (manager == null)
                {
                    lblNotFound.Show();
                }

                else
                {
                    ManagerForm f = new ManagerForm(manager);
                    this.Hide();
                    f.Show();
                }
            }

            else if (radEmployee.Checked)
            {
                Employee employee = EmployeeDL.getEmployee(txtUsername.Text, txtPassword.Text);

                if (employee == null)
                {
                    lblNotFound.Show();
                }

                EmployeeForm f = new EmployeeForm(employee);
                this.Hide();
                f.Show();
            }

            else
            {
                lblNotChosen.Show();
            }
        }

        private void radManager_CheckedChanged(object sender, EventArgs e)
        {
            lblNotChosen.Hide();
        }

        private void radEmployee_CheckedChanged(object sender, EventArgs e)
        {
            lblNotChosen.Hide();
        }

        private void radCustomer_CheckedChanged(object sender, EventArgs e)
        {
            lblNotChosen.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblNotFound.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblNotFound.Hide();
        }
    }
}
