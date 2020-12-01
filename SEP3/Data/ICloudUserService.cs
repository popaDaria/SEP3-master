using System.Threading.Tasks;
using SEP3.Model;

namespace SEP3.Data
{
    public interface ICloudUserService
    {
        public Task<LoggedUser> ValidateUser(string idNr, string password);
        public Task AddUser(User user);
        public Task<User> GetUser(string idNr);
        public Task EditUser(User user);
    }
}