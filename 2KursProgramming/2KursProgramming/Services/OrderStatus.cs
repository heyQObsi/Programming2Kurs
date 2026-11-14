using System;
using System.Collections.Generic;
using System.Text;

namespace _2KursProgramming.Services
{
    public enum OrderStatus
    {
        New,
        Processing,
        Assembly,
        Sent,
        Delivered,
        Returned,
        Abandoned
    }
}
