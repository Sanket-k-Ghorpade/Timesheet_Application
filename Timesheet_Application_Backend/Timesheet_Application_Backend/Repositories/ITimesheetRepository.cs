using Timesheet_Application_Backend.Models;
namespace Timesheet_Application_Backend.Repositories
{

    public interface ITimesheetRepository
    {
        Task<Timesheet> GetByIdAsync(int id);
        Task<IEnumerable<Timesheet>> GetByEmployeeIdAsync(int employeeId);
        Task AddAsync(Timesheet timesheet);
        void Update(Timesheet timesheet);
        void Delete(Timesheet timesheet);
        Task SaveChangesAsync();
    }
}
