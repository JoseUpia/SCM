using SCM.Domain.Core;

namespace SCM.Domain.Entities.system;

public partial class Role : AuditableFullEntity
{
    public int RoleId { get; set; }
    public string RoleName { get; set; }
}