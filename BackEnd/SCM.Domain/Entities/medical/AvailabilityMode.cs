using SCM.Domain.Core;

namespace SCM.Domain.Entities.medical;

public partial class AvailabilityMode : AuditableFullEntity
{
    public short AvailabilityModeId { get; set; }
    public string AvailabilityMode1 { get; set; }
}