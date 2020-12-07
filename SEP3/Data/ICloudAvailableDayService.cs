using System.Collections.Generic;
using System.Threading.Tasks;
using SEP3.Model;

namespace SEP3.Data
{
    public interface ICloudAvailableDayService
    {
        public Task<List<AvailableDay>> GetAvailableDays(int doctorId);
        public Task AddAvailableDay(AvailableDay availableDay);
        public Task UpdateAvailableDay(AvailableDay availableDay);
    }
}