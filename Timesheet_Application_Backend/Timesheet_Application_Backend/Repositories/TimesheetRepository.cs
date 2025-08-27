using Microsoft.EntityFrameworkCore;
using Timesheet_Application_Backend.Data;
using Timesheet_Application_Backend.Models;
namespace Timesheet_Application_Backend.Repositories
{

    public class TimesheetRepository : ITimesheetRepository
    {
        private readonly AppDbContext _context;

        public TimesheetRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Timesheet> GetByIdAsync(int id)
        {
            return await _context.Timesheets.FindAsync(id);
        }

        public async Task<IEnumerable<Timesheet>> GetByEmployeeIdAsync(int employeeId)
        {
            return await _context.Timesheets.Where(t => t.EmployeeId == employeeId).ToListAsync();
        }

        public async Task AddAsync(Timesheet timesheet)
        {
            await _context.Timesheets.AddAsync(timesheet);
        }

        public void Update(Timesheet timesheet)
        {
            _context.Timesheets.Update(timesheet);
        }

        public void Delete(Timesheet timesheet)
        {
            _context.Timesheets.Remove(timesheet);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
