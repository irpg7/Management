using IsKaiser.Management.Core.DataAccess.EntityFramework;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Linq;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework
{
    public class EfCustomerPurchasingStaffDal : EfRepositoryBase<CustomerPurchasingStaff, IsKaiserContext>, ICustomerPurchasingStaffDal
    {
    }
}
