using System.Threading.Tasks;
using SEP3.Model;

namespace SEP3.Data
{
    public interface ICloudMedicalRecordService
    {
        Task AddMedicalRecord(MedicalRecord medicalRecord);
        Task<MedicalRecord> GetMedicalRecord(int patientId);
        Task EditMedicalRecord(MedicalRecord medicalRecord);
    }
}