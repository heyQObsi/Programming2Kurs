using _2KursProgramming.Model;
using _2KursProgramming.Services;
using _2KursProgramming.View.Tabs.Controls;
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
        private string[] CustomerName = File.ReadAllLines("C:\\Users\\heyQ\\Desktop\\Новая папка (2)\\Name.txt");
        private string[] CustomerSurname = File.ReadAllLines("C:\\Users\\heyQ\\Desktop\\Новая папка (2)\\Surname.txt");
        private string[] CustomerFathername = File.ReadAllLines("C:\\Users\\heyQ\\Desktop\\Новая папка (2)\\Fathername.txt");
        private string[] CustomerAddress = File.ReadAllLines("C:\\Users\\heyQ\\Desktop\\Новая папка (2)\\Address.txt");
        public CustomersTab()
        {
            InitializeComponent();
            CustomersListbox.DataSource = customers;
            CustIdTextbox.Text = IdGenerator.CustGetCurrentId().ToString();
        }


        BindingList<Customer> customers = new BindingList<Customer>();
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddCustButton_Click(object sender, EventArgs e)
        {
            Address AddressGenerator = new Address(addressControl1.AddressConstructor.Index, addressControl1.AddressConstructor.Country, addressControl1.AddressConstructor.City, addressControl1.AddressConstructor.Street, addressControl1.AddressConstructor.Building, addressControl1.AddressConstructor.Apartment);
            Customer template_customer = new Customer(FullNameTextbox.Text, AddressGenerator);
            customers.Add(template_customer);
            CustIdTextbox.Text = IdGenerator.CustGetCurrentId().ToString();
            
        }

        private void CustRemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListbox.Items.Count != 0)
            {
                customers.RemoveAt(CustomersListbox.SelectedIndex);
            }
        }

        private void RandCustButton_Click(object sender, EventArgs e)
        {
            Address? _address = new Address(2, "Russianaaaaaa", "Tomskaaaa", "Litkinaaaaa", "8aaaa", "832aaaa");
            string[] RandomCustomer = CustomerFactory.CustGenerate(CustomerName, CustomerSurname, CustomerFathername, CustomerAddress);
            Customer template_customer = new Customer(RandomCustomer[0], _address);
            customers.Add(template_customer);
            CustIdTextbox.Text = IdGenerator.CustGetCurrentId().ToString();
        }

        private void FullNameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (FullNameTextbox.Text.Length > 200)
            {
                FullNameTextbox.BackColor = Color.Red;
            }
            else
            {
                FullNameTextbox.BackColor = Color.White;
            }
        }

        private void AddressTextbox_TextChanged(object sender, EventArgs e)
        {
            if (AddressTextbox.Text.Length > 500)
            {
                AddressTextbox.BackColor = Color.Red;
            }
            else
            {
                AddressTextbox.BackColor = Color.White;
            }
        }
        private void CustomersListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer? CustTub = CustomersListbox.SelectedItem as Customer;
            FullNameTextbox.Text = CustTub?.Fullname;
            CustIdTextbox.Text = CustTub?.Id.ToString();
            addressControl1.AddressSetter(CustTub.Address.Index, CustTub.Address.Country, CustTub.Address.City, CustTub.Address.Street, CustTub.Address.Building, CustTub.Address.Apartment);
        }
    }
}
