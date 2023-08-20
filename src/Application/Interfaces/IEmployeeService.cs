using Application.Dto;

namespace Application.Interfaces
{
    public interface IEmployeeService
    {
         EmployeeDto GetEmployeeById(int Id);
    }
}