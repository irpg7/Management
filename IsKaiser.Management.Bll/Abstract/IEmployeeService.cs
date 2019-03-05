using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee Get(int id);
        void Add(Employee employee);
        void Update(Employee employee);
        Employee GetEmployeeByCode(string empCode);
    }
}
