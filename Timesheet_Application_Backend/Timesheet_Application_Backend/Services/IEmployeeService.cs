using Timesheet_Application_Backend.Models;
namespace Timesheet_Application_Backend.Services
{

    public interface IEmployeeService
    {
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task RegisterEmployeeAsync(Employee employee);
        Task UpdateEmployeeAsync(Employee employee);
        Task DeleteEmployeeAsync(int id);
        Task<Employee> LoginAsync(string email, string password);
    }
}
