using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class Order
    {
        public string Item { get; }

        // Private backing field
        private DateTime _Date;

        public DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                if (value.Year == DateTime.Now.Year)
                {
                    _Date = value;
                }
            }
        }

        public Order(string item, DateTime date)
        {
            Item = item;
            Date = date;
        }
    }
}
