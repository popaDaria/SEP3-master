using System.Collections.Generic;
using System.Threading.Tasks;
using SEP3.Model;

namespace SEP3.Data
{
    public interface ICloudHospitalService
    {
        public Task AddHospital(Hospital hospital);
        public Task<Hospital> GetHospital(int idNr);
        public Task<List<Hospital>> GetAllHospitals();
        public Task EditHospital(Hospital Hospital);

        public Task<List<Hospital>> GetAllHospitalsValidated();
        public Task<List<Hospital>> GetAllHospitalsInvalid();
        public Task ValidateHospital(int id);
        public Task RemoveHospital(int id);

    }
}