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
    public partial class deleteCustomerForm2cs : Form
    {
        private Employee employee;
        public deleteCustomerForm2cs( Employee employee )
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!(CustomerDL.customerExist(textBox1.Text)))
            {
                lblNotFound.Show();
                btnDelete.BackColor = Color.Brown;
            }

            else
            {
                btnDelete.BackColor = Color.DarkGreen;
                lblNotFound.Hide();
            }
        }

        private void deleteCustomerForm2cs_Load(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + employee.Name;
            BankDL.Bank.compareDate();
            lblDate.Text = lblDate.Text + ":  " + BankDL.Bank.date[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CustomerDL.deleteCustomer(textBox1.Text);
            textBox1.Text = "";
            MessageBox.Show("Customer Deleted");

            CustomerDL.storeCustomer();
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
