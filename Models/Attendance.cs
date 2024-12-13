using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAttendanceManagement.Models
{
    public class Attendance
    {

       
        [Key] public int Attendace_Id { get; set; }

        [Required(ErrorMessage = "Employee Id Required.")]
        public int Employee_Id { get; set; }

        [Required(ErrorMessage = "Attendance Date is Required.")]
        public DateTime Attendance_Date { get; set; }

        [Required(ErrorMessage = "Check In Time is required.")]
        public DateTime Check_in { get; set; }

        [Required(ErrorMessage = "Check Out Time is Required.")]
        public DateTime Check_out { get; set; }

    }
}
