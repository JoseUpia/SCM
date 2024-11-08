using SCM.Domain.Entities.appointments;
using SCM.Infrastructure.Core;

namespace SCM.Infrastructure.Contract.appointments;

public interface IAppointmentDb : IDaoBase<Appointment, int>
{
}
