using _2KursProgramming.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2KursProgramming.Model
{
    internal class Address
    {
        private double? _index;
        private string? _country;
        private string? _city;
        private string? _street;
        private string? _building;
        private string? _apartament;
        //
        public string? Country
        {
            get { return _country; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "Country");
                _country = value;
            }
        }
        public string? City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "City");
                _city = value;
            }
        }
        public string? Street
        {
            get { return _street; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, "Street");
                _street = value;
            }
        }
        public string? Building
        {
            get { return _building; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "Building");
                _building = value;
            }
        }
        public string? Apartament
        {
            get { return _apartament; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "Apartament");
                _apartament = value;
            }
        }
        public Address(double? index, string? country, string? city, string? street, string? building, string? apartament)
        {
            _index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartament = apartament;
        }
    }
}
