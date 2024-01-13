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
    public partial class addNewCustomerForm : Form
    {
        private Employee employee;

        public addNewCustomerForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (CustomerDL.customerExist(txtUsername.Text))
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

        private void addNewCustomerForm_Load(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + employee.Name;
            BankDL.Bank.compareDate();
            lblDate.Text = lblDate.Text + ":  " + BankDL.Bank.date[0];
            lblTaken.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Customer cus = new Customer(txtUsername.Text, txtPassword.Text, txtName.Text, double.Parse(txtDeposit.Text));
                CustomerDL.addCustomerInList(cus);
                MessageBox.Show("User Added");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtName.Text = "";
                txtDeposit.Text = "";

                CustomerDL.storeCustomer();
            }

            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            UpdateCustomerForm f = new UpdateCustomerForm(employee);
            f.Show();
            this.Hide();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            deleteCustomerForm2cs f = new deleteCustomerForm2cs(employee);
            f.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnTransferCash_Click(object sender, EventArgs e)
        {
            transferCashForm f = new transferCashForm(employee);
            f.Show();
            this.Hide();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
