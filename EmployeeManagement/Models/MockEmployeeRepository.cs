using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
  public class MockEmployeeRepository : IEmployeeRepository
  {
    private List<Employee> _employeeList;

    public MockEmployeeRepository() 
    {
      _employeeList = new List<Employee>()
      {
        new Employee() { Id = 1, Name ="a", Email="e", Department="a" },
        new Employee() { Id = 2, Name ="b", Email="f", Department="b"},
        new Employee() { Id = 3, Name ="c", Email="g", Department="c"}
      };

    }

    public Employee GetEmployee(int Id)
    {
      return _employeeList.FirstOrDefault(e => e.Id == Id);
    }
  }
}
