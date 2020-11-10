using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
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

        public async Task AddUser(User user)
        {
            if (user.userType.Equals("patient"))
                user.validated = true;
            HttpClient client = new HttpClient();
            string usersSerialized = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(
                usersSerialized,
                Encoding.UTF8,
                "application/json"
            );
            
            //Console.WriteLine(usersSerialized);
            
            HttpResponseMessage responseMessage =
                await client.PutAsync("http://localhost:8085/users", content);
            Console.WriteLine(responseMessage.StatusCode); 
        }
    }
}