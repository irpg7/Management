using IsKaiser.Management.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework.Mapping
{
    public class CustomerAccountantMap : IEntityTypeConfiguration<CustomerAccountant>
    {
        public void Configure(EntityTypeBuilder<CustomerAccountant> builder)
        {
            builder.HasKey(ca => ca.AccountantId);
        }
    }
}
