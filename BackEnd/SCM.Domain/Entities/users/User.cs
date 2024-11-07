using SCM.Domain.Core;

namespace SCM.Domain.Entities.users;

public partial class User : AuditableFullEntity
{
    public int UserId { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int? RoleId { get; set; }
}