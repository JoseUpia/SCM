using SCM.Domain.Core;

namespace SCM.Domain.Entities.users;

public partial class Patient : AuditableFullEntity
{
    public int PatientId { get; set; }
    public string Gender { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string EmergencyContactName { get; set; }
    public string EmergencyContactPhone { get; set; }
    public string BloodType { get; set; }
    public string Allergies { get; set; }
    public int InsuranceProviderId { get; set; }
}