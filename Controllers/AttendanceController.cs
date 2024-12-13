using EmployeeAttendanceManagement.Context;
using EmployeeAttendanceManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAttendanceManagement.Controllers
{
    public class AttendanceController : Controller
    {

        public EmployeeManageDbContext _context;
        public AttendanceController(EmployeeManageDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAttendance()
        {
            var attendance = await _context.attendance.ToListAsync();
            return View(attendance);
        }

        [HttpGet]
        public IActionResult AddAttendance()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAttendance(Attendance attend)
        {
            if(ModelState.IsValid)
            {
                var attendance = await _context.attendance.AddAsync(attend);
                await _context.SaveChangesAsync();
                return RedirectToAction("GetAttendance", "Attendance");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> EditAttendance(int id)
        {
            var att = await _context.attendance.FindAsync(id);
            return View(att);
        }

        [HttpPost]
        public async Task<IActionResult> EditAttendance(Attendance attend)
        {
            var att = await _context.attendance.FindAsync(attend.Attendace_Id);
            att.Employee_Id = attend.Employee_Id;
            att.Attendance_Date = attend.Attendance_Date;
            att.Check_in = attend.Check_in;
            att.Check_out = attend.Check_out;

            await _context.SaveChangesAsync();
            return RedirectToAction("GetAttendance", "Attendance");
        }

      
        public async Task<IActionResult> DeleteAttendance(int id)
        {
            var attend = await _context.attendance.FindAsync(id);
            _context.attendance.Remove(attend);
            await _context.SaveChangesAsync();
            return RedirectToAction("GetAttendance", "Attendance");
        }
    }
}
