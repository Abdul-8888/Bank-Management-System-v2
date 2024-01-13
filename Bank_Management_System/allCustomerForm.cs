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
    public partial class allCustomerForm : Form
    {
        private Employee manager;

        public allCustomerForm(Employee manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void allCustomerForm_Load(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + manager.Name;
            BankDL.Bank.compareDate();
            lblDate.Text = lblDate.Text + ":  " + BankDL.Bank.date[0];

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = CustomerDL.getCustomerList();
            dataGridView1.Refresh();
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
    }
}
