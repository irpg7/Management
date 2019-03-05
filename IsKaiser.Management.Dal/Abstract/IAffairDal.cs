using IsKaiser.Management.Entities.ComplexTypes;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace IsKaiser.Management.Dal.Abstract
{
    public interface IAffairDal:IRepository<Affair>
    {
       
        List<AffairsListCT> GetAffairList();
    }
}
