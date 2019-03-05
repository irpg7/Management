using IsKaiser.Management.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework.Mapping
{
    public class CustomerPurchasingStaffMap : IEntityTypeConfiguration<CustomerPurchasingStaff>
    {
        public void Configure(EntityTypeBuilder<CustomerPurchasingStaff> builder)
        {
            builder.HasKey(ps => ps.PurchaseStaffId);
        }
    }
}
