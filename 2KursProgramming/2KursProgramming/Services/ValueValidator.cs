using System;
using System.Collections.Generic;
using System.Text;
using _2KursProgramming.View;
using _2KursProgramming.View.Tabs;

namespace _2KursProgramming.Services
{
    internal class ValueValidator
    {
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                Exception ex;
                MessageBox.Show("FF", $"{propertyName} должен быть меньше {maxLength} символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов");
            }
        }
    }
}
