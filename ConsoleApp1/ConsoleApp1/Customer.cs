using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Customer
    {
        private readonly int _id;
        private string _fullname;
        private string _address;

        private string Fullname
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "Fullname");
                _fullname = value;
            }
        }
        private string Address
        {
            get { return _address; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, "Address");
                _address = value;
            }
        }
        //public Customer() { }
        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
            _id = IdGenerator.Schetchiki;
        }
        //public void VvodZnach(string fullname, string address)
        //{
        //    _fullname = fullname;
        //    _address = address;
        //    _id = Schetchik.Schetchiki;
        //}
        public void VivodZnach()
        {
            Console.WriteLine(_id);
            Console.WriteLine(_fullname);
            Console.WriteLine(_address);
        }
    }
}