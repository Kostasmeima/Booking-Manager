// Booking.cs
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

    // Additional fields for group bookings
    public int Participants { get; set; }
    public bool CoachRequired { get; set; }
    public string CoachName { get; set; }

    // Additional field for individual bookings
    public bool GoldCardMember { get; set; }
    public int MembershipNumber { get; set; }
}
