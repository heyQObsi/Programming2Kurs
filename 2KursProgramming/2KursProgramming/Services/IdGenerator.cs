using System;
using System.Collections.Generic;
using System.Text;

namespace _2KursProgramming.Services
{
    internal class IdGenerator
    {
        private static int schetchiki = 0;
        public static int Schetchiki
        {
            get
            {
                return schetchiki++;
            }
        }
    }
}
