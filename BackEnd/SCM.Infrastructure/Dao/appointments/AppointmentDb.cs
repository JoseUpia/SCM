using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SCM.Domain.Context;
using SCM.Domain.Entities.appointments;
using SCM.Infrastructure.Contract.appointments;
using SCM.Infrastructure.Core;

namespace SCM.Infrastructure.Dao.appointments;

public class AppointmentDb : DaoBase<Appointment, int>, IAppointmentDb
{
    private readonly HealtSyncContext _healtSyncContext;
    private readonly ILogger<Appointment> _logger;
    private readonly IConfiguration _configuration;

    public AppointmentDb(HealtSyncContext healtSyncContext, ILogger<Appointment> logger, IConfiguration configuration) 
        : base(healtSyncContext)
    {
        _healtSyncContext = healtSyncContext;
        _logger = logger;
        _configuration = configuration;
    }

    public async override void Save(Appointment entity)
    {
        try
        {
            if (await this.Exists(a => a.DoctorId == entity.DoctorId
            && a.AppointmentDate == entity.AppointmentDate && a.StatusId == entity.StatusId))
                throw new Exception("Este doctor ya tiene una cita en este horario");

            base.Save(entity);
            await _healtSyncContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw;
        }
    }

}
