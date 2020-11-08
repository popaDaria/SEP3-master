using System.Threading.Tasks;
using SEP3.Model;

namespace SEP3.Data
{
    public interface ICloudUserService
    {
        public Task<LoggedUser> ValidateUser(string idNr, string Password);
    }
}