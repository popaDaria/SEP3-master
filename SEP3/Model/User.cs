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
        [Required] [NotNull] public string userType { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public DateTime birthday { get; set; }
        public string telNo { get; set; }
        public string address { get; set; }
        public bool validated { get; set; }
    }
}