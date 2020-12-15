using System;
using System.Collections.Generic;
using System.Text;

namespace Завдання_2
{
    class DateIndexerClass
    {
        protected DateTime date = DateTime.Today;
        public DateTime this[double i]
        {
            get
            {
                return date.AddDays(i);
            }
        }
    }
}
