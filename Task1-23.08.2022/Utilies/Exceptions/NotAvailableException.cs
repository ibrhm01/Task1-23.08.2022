using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_23._08._2022.Utilies.Exceptions
{
    class NotAvailableException:Exception
    {
        public NotAvailableException(string message):base(message)
        {

        }
    }
}
