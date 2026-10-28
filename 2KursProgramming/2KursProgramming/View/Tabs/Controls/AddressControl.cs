using _2KursProgramming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2KursProgramming.View.Tabs.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address? _address = new Address(2, "Russianaaaaaa", "Tomskaaaa", "Litkinaaaaa", "8aaaa", "832aaaa");
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Address? ControlAddress1 { 
            set { _address = value; } 
            get
            {
                if(double.TryParse(PostIndexTextbox.Text, out double K))
                {
                    _address = new Address(K, CountryTextbox.Text, CityTextbox.Text, StreetTextbox.Text, BuildingTextbox.Text, ApartmentTextbox.Text);
                }
                return _address; 
            }
        }
        public AddressControl()
        {
            InitializeComponent();
            CityTextbox.Text = ControlAddress1?.City;
            CountryTextbox.Text = ControlAddress1?.Country;
            StreetTextbox.Text = ControlAddress1?.Street;
            BuildingTextbox.Text = ControlAddress1?.Building;
            ApartmentTextbox.Text = ControlAddress1?.Apartment;
        }

        private void PostIndexTextbox_TextChanged(object sender, EventArgs e)
        {
            if (PostIndexTextbox.Text == "" || (double.TryParse(PostIndexTextbox.Text, out double index) && index >= 0 && index <= 999999))
            {
                PostIndexTextbox.BackColor = Color.White;
            }
            else
            {
                PostIndexTextbox.BackColor = Color.Red;
            }
        }

        private void CountryTextbox_TextChanged(object sender, EventArgs e)
        {
            if (CountryTextbox.Text.Length > 50)
            {
                CountryTextbox.BackColor = Color.Red;
            }
            else
            {
                CountryTextbox.BackColor = Color.White;
            }
        }

        private void CityTextbox_TextChanged(object sender, EventArgs e)
        {
            if (CityTextbox.Text.Length > 50)
            {
                CityTextbox.BackColor = Color.Red;
            }
            else
            {
                CityTextbox.BackColor = Color.White;
            }
        }

        private void StreetTextbox_TextChanged(object sender, EventArgs e)
        {
            if (StreetTextbox.Text.Length > 100)
            {
                StreetTextbox.BackColor = Color.Red;
            }
            else
            {
                StreetTextbox.BackColor = Color.White;
            }
        }

        private void BuildingTextbox_TextChanged(object sender, EventArgs e)
        {
            if (BuildingTextbox.Text.Length > 10)
            {
                BuildingTextbox.BackColor = Color.Red;
            }
            else
            {
                BuildingTextbox.BackColor = Color.White;
            }
        }

        private void ApartmentTextbox_TextChanged(object sender, EventArgs e)
        {
            if (ApartmentTextbox.Text.Length > 10)
            {
                ApartmentTextbox.BackColor = Color.Red;
            }
            else
            {
                ApartmentTextbox.BackColor = Color.White;
            }
        }
    }
}
