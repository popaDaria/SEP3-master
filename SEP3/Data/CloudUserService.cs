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
            string message = await client.GetStringAsync("https://localhost:8085/users?idNr="+idNr);
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
            loggedUser.userType = result.userType;
            if (result.validated)
            {
                loggedUser.validated = "true";
            }
            else
            {
                loggedUser.validated = "false";
            }
            return loggedUser;
        }

        
        public async Task ValidateManager(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("https://localhost:8085/users/manager?id="+id);
            Console.WriteLine(message);
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
                await client.PutAsync("https://localhost:8085/users", content);
            Console.WriteLine(responseMessage.StatusCode); 
        }

        public async Task AddDoctor(User user)
        {
            HttpClient client = new HttpClient();
            string usersSerialized = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(
                usersSerialized,
                Encoding.UTF8,
                "application/json"
            );
            
            HttpResponseMessage responseMessage =
                await client.PutAsync("https://localhost:8085/users/doctor", content);
            Console.WriteLine(responseMessage.StatusCode); 
        }

        public async Task<User> GetUser(string idNr)
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("https://localhost:8085/users?idNr="+idNr);
            Console.WriteLine(message);
            User result = JsonSerializer.Deserialize<User>(message);
            return result;
        }

        public async Task<List<User>> GetUnvalidatedUsers()
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("https://localhost:8085/users/unvalidated");
            Console.WriteLine(message);
            List<User> result = JsonSerializer.Deserialize<List<User>>(message);
            return result;        
        }

        public async Task EditUser(User user)
        {
            HttpClient client = new HttpClient();
            string usersSerialized = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(
                usersSerialized,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage message = await client.PatchAsync("https://localhost:8085/users", content);
            Console.WriteLine(message.StatusCode);
        }
    }
}