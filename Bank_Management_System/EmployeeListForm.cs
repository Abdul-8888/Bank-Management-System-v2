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
    public partial class workSortForm : Form
    {
        private Employee manager;

        public workSortForm(Employee manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void workSortForm_Load(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + manager.Name;
            BankDL.Bank.compareDate();
            lblDate.Text = lblDate.Text + ":  " + BankDL.Bank.date[0];

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = EmployeeDL.getEmployeeList();
            dataGridView1.Refresh();
        }
    }
}
