using SCM.Domain.Core;

namespace SCM.Domain.Entities.medical;

public partial class MedicalRecord : AuditableEntity
{
    public int RecordId { get; set; }
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public string Diagnosis { get; set; }
    public string Treatment { get; set; }
    public DateTime DateOfVisit { get; set; }
}