namespace SCM.Domain.Entities.users;

public partial class Person
{
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string IdentificationNumber { get; set; }
    public string Gender { get; set; }
}