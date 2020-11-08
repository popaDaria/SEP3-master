using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Formatters;
using SEP3.Model;

namespace SEP3.Data
{
    public class CloudUserService : ICloudUserService
    {
        public async Task<LoggedUser> ValidateUser(string idNr, string Password)
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("http://localhost:8085/users?idNr="+idNr);
            Console.WriteLine(message);
            User result = JsonSerializer.Deserialize<User>(message);
            
            if (result == null) {
                throw new Exception("User not found");
            }
            if (!result.password.Equals(Password)) {
                throw new Exception("Incorrect password");
            }
            LoggedUser loggedUser = new LoggedUser();
            loggedUser.password = Password;
            loggedUser.username = idNr;
            return loggedUser;
        }
    }
}