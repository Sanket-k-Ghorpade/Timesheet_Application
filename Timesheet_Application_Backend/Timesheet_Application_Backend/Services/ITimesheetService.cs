using Timesheet_Application_Backend.Models;
namespace Timesheet_Application_Backend.Services
{

    public interface ITimesheetService
    {
        Task<Timesheet> GetTimesheetByIdAsync(int id);
        Task<IEnumerable<Timesheet>> GetTimesheetsForEmployeeAsync(int employeeId);
        Task<Timesheet> AddTimesheetAsync(Timesheet timesheet);
        Task UpdateTimesheetAsync(Timesheet timesheet);
        Task DeleteTimesheetAsync(int id);
    }
}
