using System;
using System.Collections.Generic;
using System.Text;

namespace _2KursProgramming.Services
{
    internal class IdGenerator
    {
        private static int ItemId = 0;
        private static int CustId = 0;
        public static int ItemGetNextId()
        {
            return ItemId++;
        }
        public static int ItemGetCurrentId()
        {
            return ItemId;
        }
        public static int CustGetNextId()
        {
            return CustId++;
        }
        public static int CustGetCurrentId()
        {
            return CustId;
        }
    }
}
