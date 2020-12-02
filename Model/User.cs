using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace SEP3.Model
{
    public class User
    {
        [Required] [NotNull] public int idNr { get; set; }
        [Required] [NotNull] public string password { get; set; }
        [Required] [NotNull] public string firstname { get; set; }
        [Required] [NotNull] public string lastname { get; set; }
        public string userType { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public DateTime birthday { get; set; }
        public string telNo { get; set; }
        public string address { get; set; }
        public bool validated { get; set; }
        public byte[] image { get; set; }

        public void Update(User user)
        {
            this.idNr = user.idNr;
            this.password = user.password;
            this.firstname = user.firstname;
            this.lastname = user.lastname;
            this.userType = user.userType;
            this.email = user.email;
            this.gender = user.gender;
            this.birthday = user.birthday;
            this.telNo = user.telNo;
            this.address = user.address;
            this.validated = user.validated;
            this.image = user.image;
        }
    }
}