using IsKaiser.Management.Core.DataAccess;
using IsKaiser.Management.Entities.ComplexTypes;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace IsKaiser.Management.Dal.Abstract
{
    public interface IAffairDal:IEntityRepository<Affair>
    {
       
        List<AffairsListCT> GetAffairList();
    }
}
