using SCM.Domain.Core;

namespace SCM.Domain.Entities.Insurance;

public partial class NetworkType : AuditableFullEntity
{
    public int NetworkTypeId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}