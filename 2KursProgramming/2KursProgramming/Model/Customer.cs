using _2KursProgramming.Model;
using _2KursProgramming.Services;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2KursProgramming.Model
{
    internal class Customer
    {
        private readonly int _id;
        private string _fullname;
        private string _address;

        public string Fullname
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "Fullname");
                _fullname = value;
            }
        }
        public string Address
        {
            get { return _address; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, "Address");
                _address = value;
            }
        }
        public Customer() { }
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
        public override string ToString()
        {
            // Возвращаем строку в том виде, в каком хотим видеть её в Листбоксе
            return $"Имя: {_fullname} Адресс: {Address}";
        }
    }
}