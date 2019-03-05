using IsKaiser.Management.Core.DataAccess.EntityFramework;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.ComplexTypes;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework
{
    public class EfAffairDal : EfRepositoryBase<Affair, IsKaiserContext>, IAffairDal
    {
        public List<AffairsListCT> GetAffairList()
        {
            using (IsKaiserContext context=new IsKaiserContext())
            {
                var complexList = (from a in context.Affairs
                                   join c in context.Customers on a.CustomerId equals c.CustomerId
                                   select new AffairsListCT {
                                       AffairDate=a.AffairDate,
                                       CustomerName=c.CustomerName,
                                       Project=a.Project
                                   }).ToList();
                return complexList;
            }
            
        }
    }
}
