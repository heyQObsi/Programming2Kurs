using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using _2KursProgramming.Services;

namespace _2KursProgramming.Model
{
    public class Item
    {
        /// <summary>
        /// Уникальный номер товара в БД
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Наименование товара
        /// </summary>
        private string _name = null;
        /// <summary>
        /// Информация о товаре
        /// </summary>
        private string _info = null;
        /// <summary>
        /// Стоимость товара
        /// </summary>
        private double _cost;
        /// <summary>
        /// Возвращает и задаёт наименование товара. Длина названия не должна превыщать 200 символов
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "Name");
                _name = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт информацию о товаре. Длина информации не должна превыщать 1000 символов
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, "Info");
                _info = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт стоимость товара. Содержит только числа в диапозоне (0; 100000)
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value < 0 || value > 100000)
                    throw new ArgumentException($"Cost должен быть в диапозоне от 0 до 100.000");
                _cost = value;
            }
        }
        public int Id => _id;
        public Category Category
        {
            get;
            set;
        }
        public Item() {}
        /// <summary>
        /// Создаёт экземляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="name">Наименование товара</param>
        /// <param name="info">Информация о товаре</param>
        /// <param name="cost">Стоимость товара</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = IdGenerator.ItemGetNextId();
            Category = category;
        }
        public override string ToString()
        {
            // Возвращаем строку в том виде, в каком хотим видеть её в Листбоксе
            return $"ID: {_id} Cost: {_cost} Имя: {_name} Инфо {_info}";
        }
    }
}
