using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking_Exercise
{
    public class HotelBooking
    {
        public string GuestName;
        public DateTime StartDate;
        public DateTime EndDate;

        public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
        {
            GuestName = guestName;
            StartDate = startDate;
            EndDate = startDate.AddDays(lengthOfStayInDays);
        }
    }
}
