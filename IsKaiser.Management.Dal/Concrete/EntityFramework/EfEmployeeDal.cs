﻿using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework
{
    public class EfEmployeeDal:EfRepositoryBase<Employee,IsKaiserContext>,IEmployeeDal
    {
    }
}
