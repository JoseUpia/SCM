namespace SCM.Domain.Entities.appointments;

public partial class DoctorAvailability
{
    public int AvailabilityId { get; set; }
    public int DoctorId { get; set; }
    public DateTime AvailableDate { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
}