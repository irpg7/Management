using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Core.Aspects.Postsharp.ValidationAspects;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System.Collections.Generic;

namespace IsKaiser.Management.Bll.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
        [FluentValidationAspect(typeof(EmployeeValidator))]
        public void Add(Employee employee)
        {
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
        [FluentValidationAspect(typeof(EmployeeValidator))]
        public void Update(Employee employee)
        {
            _employeeDal.Update(employee);
        }
    }
}
