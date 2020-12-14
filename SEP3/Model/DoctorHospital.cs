using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SEP3.Model
{
    public class DoctorHospital
    {
        [Required] [NotNull] public int doctorId { get; set; }
        [Required] [NotNull] public int hospitalId { get; set; }
        [Required] [NotNull] public string deptName { get; set; }
    }
}