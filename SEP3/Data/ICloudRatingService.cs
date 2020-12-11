using System.Collections.Generic;
using System.Threading.Tasks;
using SEP3.Model;

namespace SEP3.Data
{
    public interface ICloudRatingService
    {
        Task AddRating(Rating rating);
        Task<List<Rating>> GetAllForHospital(int hospitalId);
    }
}