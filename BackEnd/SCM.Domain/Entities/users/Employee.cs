using SCM.Domain.Core;

namespace SCM.Domain.Entities.users;

public partial class Employee : AuditableFullEntity
{
    public int EmployeeId { get; set; }
    public string PhoneNumber { get; set; }
    public string JobTitle { get; set; }
}