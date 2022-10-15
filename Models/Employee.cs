using System.ComponentModel.DataAnnotations;

namespace CFA_Dot_Net.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Enter the Employee Name")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Name must consist of minimum 4 characters")]
        public string name { get; set; }
        [Required(ErrorMessage = "Enter the Product Brand")]
        public String Designation { get; set; }
    }
}
