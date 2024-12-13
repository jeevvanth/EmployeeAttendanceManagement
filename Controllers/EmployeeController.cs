using EmployeeAttendanceManagement.Context;
using EmployeeAttendanceManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAttendanceManagement.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeManageDbContext _context;
        public EmployeeController(EmployeeManageDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployee()
        {
            var employees = await _context.employee.ToListAsync();
            return View(employees);
        }
        [HttpGet]

        public async Task<IActionResult> GetEmployeebyid(int id) 
        {
            var employee = await _context.employee.FirstOrDefaultAsync(e => e.Employee_Id == id);
            return View(employee);
        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            if(ModelState.IsValid)
            {
                var emp = await _context.employee.AddAsync(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction("GetEmployee", "Employee");
            }
            return View();

        }
        [HttpGet]
        public async Task<IActionResult> EditEmployee(int id)
        {
            var employee = await _context.employee.FindAsync(id);
            return View(employee);
        }
        [HttpPost]
        public async Task<IActionResult> EditEmployee(Employee emp)
        {
            var employee= await _context.employee.FindAsync(emp.Employee_Id);

         
            employee.Employee_Name= emp.Employee_Name;
            employee.Employee_Email= emp.Employee_Email;
            employee.Employee_Department= emp.Employee_Department;
            await _context.SaveChangesAsync();

            return RedirectToAction("GetEmployee","Employee");

        }

        public async  Task<IActionResult> DeleteEmployee(int id) 
        {
            var removeEmp = await _context.employee.FindAsync(id);
            _context.employee.Remove(removeEmp);
            await _context.SaveChangesAsync();
            return RedirectToAction("GetEmployee", "Employee");
        }
    }
}
