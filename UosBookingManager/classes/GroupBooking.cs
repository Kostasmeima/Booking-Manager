using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UosBookingManager.classes
{
    [Serializable]
    public class GroupBooking : Booking
    {
        public int Participants { get; set; }
        public bool CoachRequired { get; set; }
        public string CoachName { get; set; }

        public override string ToString()
        {
            var coachInfo = CoachRequired ? $"Coach: {CoachName}" : "No coach required";
            return $"{base.ToString()}, Participants: {Participants}, {coachInfo}";
        }
    }
}
