using IsKaiser.Management.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework.Mapping
{
    public class CompanyBankAccountMap : IEntityTypeConfiguration<CompanyBankAccount>
    {
        public void Configure(EntityTypeBuilder<CompanyBankAccount> builder)
        {
            builder.HasKey(cb => cb.AccountId);
        }
    }
}
