using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Core.Aspects.Postsharp.ValidationAspects;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IsKaiser.Management.Bll.Concrete
{
    public class EmployeeTeamManager : IEmployeeTeamService
    {
        IEmployeeTeamDal _employeeTeamDal;

        public EmployeeTeamManager(IEmployeeTeamDal employeeTeamDal)
        {
            _employeeTeamDal = employeeTeamDal;
        }
        [FluentValidationAspect(typeof(TeamValidator))]
        public void Add(EmployeeTeam employeeTeam)
        {
            
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
        [FluentValidationAspect(typeof(TeamValidator))]
        public void Update(EmployeeTeam employeeTeam)
        {
           
            _employeeTeamDal.Update(employeeTeam);
        }
    }
}
