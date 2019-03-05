using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface IEmployeeTeamService
    {
        List<EmployeeTeam> GetAll();
        EmployeeTeam Get(int id);
        void Add(EmployeeTeam employeeTeam);
        void Update(EmployeeTeam employeeTeam);
    }
}
