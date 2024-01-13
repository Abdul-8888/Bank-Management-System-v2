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
    public partial class transferCashForm : Form
    {
        private Employee employee;

        public transferCashForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void transferCashForm_Load(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + employee.Name;
            BankDL.Bank.compareDate();
            lblDate.Text = lblDate.Text + ":  " + BankDL.Bank.date[0];
            lblNotFound.Hide();
        }

        private void txtSender_TextChanged(object sender, EventArgs e)
        {
            if (!(CustomerDL.customerExist(txtSender.Text)))
            {
                lblNotFound.Show();
                btnTransfer.BackColor = Color.Brown;
            }

            else
            {
                btnTransfer.BackColor = Color.DarkGreen;
                lblNotFound.Hide();
            }
        }

        private void txtRecipient_TextChanged(object sender, EventArgs e)
        {
            if (!(CustomerDL.customerExist(txtRecipient.Text)))
            {
                lblNotFound.Show();
                btnTransfer.BackColor = Color.Brown;
            }

            else
            {
                btnTransfer.BackColor = Color.DarkGreen;
                lblNotFound.Hide();
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c1 = CustomerDL.getCustomer(txtSender.Text);
                Customer c2 = CustomerDL.getCustomer(txtRecipient.Text);

                c1.withdrawCash(double.Parse(txtAmount.Text));
                c2.depositCash(double.Parse(txtAmount.Text));

                MessageBox.Show("Cash Transfered.");
                txtSender.Text = "";
                txtRecipient.Text = "";

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
    }
    
}
