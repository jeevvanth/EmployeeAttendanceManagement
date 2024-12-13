using System.ComponentModel.DataAnnotations;

namespace EmployeeAttendanceManagement.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Employee Id Required.")]
        [Key]   public int Employee_Id { get; set; }

        [Required(ErrorMessage = "Employee Name is Required.")]
        public string? Employee_Name { get; set; }

        [Required(ErrorMessage = "Employee Email Required.")]
        public string? Employee_Email { get; set; }

        [Required(ErrorMessage = "Employee Department Required.")]
        public string? Employee_Department { get; set; }
    }
}
