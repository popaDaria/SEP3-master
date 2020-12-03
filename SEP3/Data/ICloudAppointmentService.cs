using System.Collections.Generic;
using System.Threading.Tasks;
using SEP3.Model;

namespace SEP3.Data
{
    public interface ICloudAppointmentService
    {
        public Task<List<Appointment>> GetAllForPatient(int id);
        public Task<List<Appointment>> GetAllForDoctor(int id);
    }
}