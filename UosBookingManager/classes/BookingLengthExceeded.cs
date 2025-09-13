using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UosBookingManager.classes
{
    public class BookingLengthExceeded : Exception
    {
        public BookingLengthExceeded(string message) : base(message) { }
    }
}
