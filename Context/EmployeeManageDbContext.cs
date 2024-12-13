using EmployeeAttendanceManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAttendanceManagement.Context
{
    public class EmployeeManageDbContext:DbContext
    {
        public EmployeeManageDbContext(DbContextOptions<EmployeeManageDbContext> options):base(options)
        {
            
        }

        public DbSet<Employee> employee { get; set; }
        public DbSet<Attendance> attendance { get; set; }

      

    }
}
