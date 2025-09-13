using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UosBookingManager.classes
{
    [Serializable]
    public class Booking
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public int Duration { get; set; }
        public string Activity { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Date: {Date.ToShortDateString()}, Start: {StartTime}, Duration: {Duration} hours, Activity: {Activity}, Contact: {ContactName}";
        }
    }

}
