using _2KursProgramming.Model;
using _2KursProgramming.Services;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2KursProgramming.Model
{
    public class Customer
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
        private Address? _address;
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
        public int Id => _id;
        /// <summary>
        /// Возвращает и задёт адрес проживания клиента. Длина адреса не должна превыщать 500 символов.
        /// </summary>
        public Address? Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }
        public Customer() { }
        /// <summary>
        /// Создаёт экземляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Полное имя клиента</param>
        /// <param name="address">Фактический адрес проживания клиента</param>
        public Customer(string fullname, Address address)
        {
            Fullname = fullname;
            Address = address;
            _id = IdGenerator.CustGetNextId();
        }
        public override string ToString()
        {
            // Возвращаем строку в том виде, в каком хотим видеть её в Листбоксе
            return $"ID: {_id} Имя: {_fullname} Адресс: Индекс: {Address?.Index} Страна:{Address?.Country} Город: {Address?.City} Улица: {Address?.Street} Дом: {Address?.Building} Квартира: {Address?.Apartment}";
        }
    }
}