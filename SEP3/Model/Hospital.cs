using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SEP3.Model
{
    public class Hospital
    {
        public int id { get; set; }
        [Required] [NotNull] public string name { get; set; }
        [Required] [NotNull] public string address { get; set; }
        [Required] [NotNull] public int postalCode { get; set; }
        [Required] [NotNull] public string info { get; set; }
        public string avgRating { get; set; }
        public string type { get; set; }
        public int managerId { get; set; }
        [Required] [NotNull] public bool validated { get; set; }
        public byte[] image;

    }
}