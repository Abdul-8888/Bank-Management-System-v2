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
    public partial class UpdateCustomerForm : Form
    {
        private Employee employee;
        public UpdateCustomerForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void UpdateCustomerForm_Load(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + employee.Name;
            BankDL.Bank.compareDate();
            lblDate.Text = lblDate.Text + ":  " + BankDL.Bank.date[0];
            lblNotFound.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (!(CustomerDL.customerExist(txtUsername.Text)))
            {
                lblNotFound.Show();
                btnProceed.BackColor = Color.Brown;
            }

            else
            {
                btnProceed.BackColor = Color.DarkGreen;
                lblNotFound.Hide();
            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                if (radDeposit.Checked)
                {
                    Customer cus = CustomerDL.getCustomer(txtUsername.Text);
                    MessageBox.Show("New Account Balance is " + cus.depositCash(double.Parse(txtAmount.Text)).ToString());
                }

                else if (radWithdraw.Checked)
                {
                    Customer cus = CustomerDL.getCustomer(txtUsername.Text);
                    MessageBox.Show("New Account Balance is " + cus.withdrawCash(double.Parse(txtAmount.Text)).ToString());
                }

                else
                {
                    lblNotFound.Text = "Please select an Option.";
                    lblNotFound.Show();
                }

                txtUsername.Text = "";
                txtAmount.Text = "";
                radDeposit.Checked = false;
                radWithdraw.Checked = false;

                CustomerDL.storeCustomer();
            }

            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            addNewCustomerForm f = new addNewCustomerForm(employee);
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

    }
}
