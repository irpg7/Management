using IsKaiser.Management.Core.DataAccess.EntityFramework;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework
{
    public class EfEmployeeTeamDal:EfRepositoryBase<EmployeeTeam,IsKaiserContext>,IEmployeeTeamDal
    {
    }
}
