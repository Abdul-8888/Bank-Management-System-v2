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
    public partial class HireEmployeeForm : Form
    {
        private Employee manager;

        public HireEmployeeForm(Employee manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void HireEmployeeForm_Load(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + manager.Name;
            BankDL.Bank.compareDate();
            lblDate.Text = lblDate.Text + ":  " + BankDL.Bank.date[0];
            lblTaken.Hide();
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {
            if( EmployeeDL.employeeExist(txtUsername.Text) )
            {
                lblTaken.Show();
                btnSubmit.BackColor = Color.Brown;
            }

            else
            {
                btnSubmit.BackColor = Color.DarkGreen;
                lblTaken.Hide();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee(txtUsername.Text, txtPassword.Text, txtName.Text, int.Parse(txtAge.Text), float.Parse(txtSalary.Text));
                EmployeeDL.addEmployeeInList(emp);
                MessageBox.Show("User Added");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtName.Text = "";
                txtAge.Text = "";
                txtSalary.Text = "";

                EmployeeDL.storeEmployee();
            }

            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnFireEmployee_Click(object sender, EventArgs e)
        {
            fireEmployeeForm f = new fireEmployeeForm(manager);
            f.Show();
            this.Hide();
        }

        private void btnAllEmployees_Click(object sender, EventArgs e)
        {
            allEmployeeForm f = new allEmployeeForm(manager);
            f.Show();
            this.Hide();
        }

        private void btnBlockCustomer_Click(object sender, EventArgs e)
        {
            blockCustomerForm f = new blockCustomerForm(manager);
            f.Show();
            this.Hide();
        }

        private void btnFlow_Click(object sender, EventArgs e)
        {
            flowForm f = new flowForm(manager);
            f.Show();
            this.Hide();
        }

        private void btnAllCustomers_Click(object sender, EventArgs e)
        {
            allCustomerForm f = new allCustomerForm(manager);
            f.Show();
            this.Hide();
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            InterestForm f = new InterestForm(manager);
            f.Show();
            this.Hide();
        }

        private void btnBonus_Click(object sender, EventArgs e)
        {
            BonusForm f = new BonusForm(manager);
            f.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropDown.Text == "Bubble Sort")
            {
                EmployeeDL.bubbleSort();
            }

            else if (dropDown.Text == "Selection Sort")
            {
                EmployeeDL.selectionSort();
            }

            else if (dropDown.Text == "Insertion Sort")
            {
                EmployeeDL.insertionSort();
            }

            else if (dropDown.Text == "Merge Sort")
            {
                EmployeeDL.mergeSort(0, EmployeeDL.allEmployees.Count - 1);
            }

            else if (dropDown.Text == "Quick Sort")
            {
                EmployeeDL.quickSort(0, EmployeeDL.allEmployees.Count - 1);
            }

            else if (dropDown.Text == "Heap Sort")
            {
                EmployeeDL.heapSort();
            }

            else if (dropDown.Text == "Counting Sort")
            {
                EmployeeDL.countingSort();
            }

            else if (dropDown.Text == "Radix Sort")
            {
                EmployeeDL.radixSort();
            }

            else if (dropDown.Text == "Bucket Sort")
            {
                EmployeeDL.bucketSort();
            }

            allEmployeeForm f = new allEmployeeForm(manager);
            f.Show();
            this.Hide();
        }
    }
}
