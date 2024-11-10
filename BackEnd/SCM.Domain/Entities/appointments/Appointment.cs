using SCM.Domain.Core;

namespace SCM.Domain.Entities.appointments;

public partial class Appointment : AuditableEntity
{
    public int AppointmentId { get; set; }
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public DateTime AppointmentDate { get; set; }
    public int StatusId { get; set; }
}