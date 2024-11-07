using SCM.Domain.Core;

namespace SCM.Domain.Entities.medical;

public partial class Specialty : AuditableFullEntity
{
    public short SpecialtyId { get; set; }
    public string SpecialtyName { get; set; }
}