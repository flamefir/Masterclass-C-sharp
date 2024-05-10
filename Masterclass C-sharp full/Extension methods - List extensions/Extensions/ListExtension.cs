using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_methods___List_extensions.Extensions
{
    public static class ListExtension
    {
        public static List<int> TakeEverySecond(this List<int> list)
        {
            var everySecondItem = new List<int>();
            for (int i = 0; i < list.Count; i+=2)
            {
                everySecondItem.Add(list[i]);
            }
            return everySecondItem;
        }
    }
}
