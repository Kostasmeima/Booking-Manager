using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UosBookingManager.classes
{
    [Serializable]
    public class IndividualBooking : Booking
    {
        public bool GoldCardMember { get; set; }
        public string MembershipNumber { get; set; }

        public override string ToString()
        {
            var memberInfo = GoldCardMember ? $"Gold Card Member: {MembershipNumber}" : "Standard Member";
            return $"{base.ToString()}, {memberInfo}";
        }
    }
}
