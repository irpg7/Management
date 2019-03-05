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
    public class EmployeeTeamManager : IEmployeeTeamService
    {
        IEmployeeTeamDal _employeeTeamDal;

        public EmployeeTeamManager(IEmployeeTeamDal employeeTeamDal)
        {
            _employeeTeamDal = employeeTeamDal;
        }

        public void Add(EmployeeTeam employeeTeam)
        {
            ValidationTool.Validate(new TeamValidator(), employeeTeam);
            _employeeTeamDal.Add(employeeTeam);
        }

        public EmployeeTeam Get(int id)
        {
            return _employeeTeamDal.Get(et => et.TeamId == id);
        }

        public List<EmployeeTeam> GetAll()
        {
            return _employeeTeamDal.GetAll();
        }

        public void Update(EmployeeTeam employeeTeam)
        {
            ValidationTool.Validate(new TeamValidator(), employeeTeam);
            _employeeTeamDal.Update(employeeTeam);
        }
    }
}
