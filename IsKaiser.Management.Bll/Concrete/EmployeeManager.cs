using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.Utilities;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Bll.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void Add(Employee employee)
        {
            ValidationTool.Validate(new EmployeeValidator(), employee);
            _employeeDal.Add(employee);
        }

        public Employee Get(int id)
        {
           return _employeeDal.Get(emp => emp.EmployeeId == id);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }

        public Employee GetEmployeeByCode(string empCode)
        {
            return _employeeDal.Get(emp => emp.EmployeeCode == empCode);
        }

        public void Update(Employee employee)
        {
            ValidationTool.Validate(new EmployeeValidator(), employee);
            _employeeDal.Update(employee);
        }
    }
}
