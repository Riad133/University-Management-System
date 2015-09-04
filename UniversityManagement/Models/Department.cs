using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace UniversityManagement.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "You Must Fill Department Code Field")]
        [Index(IsUnique = true)]
        [MaxLength(32)]

        public string DepartmentCode { get; set; }

    
        [Required(ErrorMessage = "You Must Fill Department Name Field")]
        [Index(IsUnique = true)]
        [MaxLength(32)]
        public string DepartmentName { get; set; }
    }
}