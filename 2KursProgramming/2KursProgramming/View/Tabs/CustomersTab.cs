using _2KursProgramming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2KursProgramming.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        public CustomersTab()
        {
            InitializeComponent();
            CustomersListbox.DataSource = customers;
        }


        BindingList<Customer> customers = new BindingList<Customer>();
        Customer template_customer = new Customer();
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddCustButton_Click(object sender, EventArgs e)
        {
            customers.Add(template_customer);
        }

        private void FullNameTextbox_TextChanged(object sender, EventArgs e)
        {
            template_customer.Fullname = FullNameTextbox.Text;
        }

        private void AddressTextbox_TextChanged(object sender, EventArgs e)
        {
            template_customer.Address = AddressTextbox.Text;
        }

        private void CustomersListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustRemoveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
