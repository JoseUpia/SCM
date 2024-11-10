using SCM.Domain.Core;

namespace SCM.Domain.Entities.users;

public partial class Doctor : AuditableFullEntity
{
    public int DoctorId { get; set; }
    public short SpecialtyId { get; set; }
    public string LicenseNumber { get; set; }
    public string PhoneNumber { get; set; }
    public int YearsOfExperience { get; set; }
    public string Education { get; set; }
    public string Bio { get; set; }
    public decimal? ConsultationFee { get; set; }
    public string ClinicAddress { get; set; }
    public short? AvailabilityModeId { get; set; }
    public DateTime LicenseExpirationDate { get; set; }
}