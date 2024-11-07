namespace SCM.Domain.Entities.system;

public partial class Notification
{
    public int NotificationId { get; set; }
    public int UserId { get; set; }
    public string Message { get; set; }
    public DateTime? SentAt { get; set; }
}