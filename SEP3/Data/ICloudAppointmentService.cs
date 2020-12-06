using System.Collections.Generic;
using System.Threading.Tasks;
using SEP3.Model;

namespace SEP3.Data
{
    public interface ICloudAppointmentService
    {
        List<ScheduleData.DoctorsEventData> GetAppointmentData();
        Task<List<Appointment>> GetAllForDoctor(int id);
        Task<List<Appointment>> GetAllForPatient(int id);
        Task MakeAppointment(Appointment appointment);
        Task UpdateAppointment(Appointment appointment);
    }
}