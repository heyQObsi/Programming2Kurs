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
        /// <summary>
        /// Уникальный номер клиента в БД
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Полное имя клиента
        /// </summary>
        private string _fullname = null;
        /// <summary>
        /// Фактический адрес проживания клиента
        /// </summary>
        private string _address = null;
        /// <summary>
        /// Возвращает и задаёт полное имя клиента. Длина имени не должна превыщать 200 символов.
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "Fullname");
                _fullname = value;
            }
        }
        /// <summary>
        /// Возвращает и задёт адрес проживания клиента. Длина адреса не должна превыщать 500 символов.
        /// </summary>
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
        /// <summary>
        /// Создаёт экземляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Полное имя клиента</param>
        /// <param name="address">Фактический адрес проживания клиента</param>
        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
            _id = IdGenerator.Schetchiki;
        }
        public override string ToString()
        {
            // Возвращаем строку в том виде, в каком хотим видеть её в Листбоксе
            return $"Имя: {_fullname} Адресс: {Address}";
        }
    }
}