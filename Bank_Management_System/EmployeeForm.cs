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
    public partial class EmployeeForm : Form
    {
        private Employee employee;

        public EmployeeForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + employee.Name;
            BankDL.Bank.compareDate();
            lblDate.Text = lblDate.Text + ":  " + BankDL.Bank.date[0];
            lblAge.Text = (employee.Age).ToString();
            lblSalary.Text = (employee.Salary).ToString();
            lblRequired.Hide();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            employee.WorkingHours = int.Parse(txtWorkingHours.Text);
            txtWorkingHours.Text = "";
            lblRequired.Hide();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (employee.WorkingHours != 0)
            {
                addNewCustomerForm f = new addNewCustomerForm(employee);
                f.Show();
                this.Hide();
            }

            else
            {
                lblRequired.Show();
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (employee.WorkingHours != 0)
            {
                UpdateCustomerForm f = new UpdateCustomerForm(employee);
                f.Show();
                this.Hide();
            }

            else
            {
                lblRequired.Show();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (employee.WorkingHours != 0)
            {
                deleteCustomerForm2cs f = new deleteCustomerForm2cs(employee);
                f.Show();
                this.Hide();
            }

            else
            {
                lblRequired.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnTransferCash_Click(object sender, EventArgs e)
        {
            if (employee.WorkingHours != 0)
            {
                transferCashForm f = new transferCashForm(employee);
                f.Show();
                this.Hide();
            }

            else
            {
                lblRequired.Show();
            }
        }

    }
}
