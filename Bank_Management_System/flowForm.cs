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
    public partial class flowForm : Form
    {
        private Employee manager;

        public flowForm(Employee manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void flowForm_Load(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + manager.Name;
            BankDL.Bank.compareDate();
            lblDate.Text = lblDate.Text + ":  " + BankDL.Bank.date[0];

            lblDay1.Text = BankDL.Bank.date[0];
            lblDay2.Text = BankDL.Bank.date[1];
            lblDay3.Text = BankDL.Bank.date[2];
            lblDay4.Text = BankDL.Bank.date[3];
            lblDay5.Text = BankDL.Bank.date[4];
            lblDay6.Text = BankDL.Bank.date[5];
            lblDay7.Text = BankDL.Bank.date[6];

            lblIn1.Text = (BankDL.Bank.cashIn[0]).ToString();
            lblIn2.Text = (BankDL.Bank.cashIn[1]).ToString();
            lblIn3.Text = (BankDL.Bank.cashIn[2]).ToString();
            lblIn4.Text = (BankDL.Bank.cashIn[3]).ToString();
            lblIn5.Text = (BankDL.Bank.cashIn[4]).ToString();
            lblIn6.Text = (BankDL.Bank.cashIn[5]).ToString();
            lblIn7.Text = (BankDL.Bank.cashIn[6]).ToString();

            lblOut1.Text = (BankDL.Bank.cashOut[0]).ToString();
            lblOut2.Text = (BankDL.Bank.cashOut[1]).ToString();
            lblOut3.Text = (BankDL.Bank.cashOut[2]).ToString();
            lblOut4.Text = (BankDL.Bank.cashOut[3]).ToString();
            lblOut5.Text = (BankDL.Bank.cashOut[4]).ToString();
            lblOut6.Text = (BankDL.Bank.cashOut[5]).ToString();
            lblOut7.Text = (BankDL.Bank.cashOut[6]).ToString();
        }

        private void btnHireEmployee_Click(object sender, EventArgs e)
        {
            HireEmployeeForm f = new HireEmployeeForm(manager);
            f.Show();
            this.Hide();
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
