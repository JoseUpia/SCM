namespace SCM.Domain.Core;

public class AuditableFullEntity : AuditableEntity
{
    public bool IsActive { get; set; }
}
