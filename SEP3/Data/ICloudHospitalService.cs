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
        public Task<List<string>> GetAllDepartments(int hosId);

        public Task<List<Hospital>> GetAllHospitalsValidated();
        public Task<List<Hospital>> GetAllHospitalsInvalid();
        public Task<List<Hospital>> GetAllHospitalsForManager(int id);
        public Task ValidateHospital(int id);
        public Task RemoveHospital(int id);

    }
}