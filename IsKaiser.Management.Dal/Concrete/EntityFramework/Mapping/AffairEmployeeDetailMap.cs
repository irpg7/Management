using IsKaiser.Management.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework.Mapping
{
    public class AffairEmployeeDetailMap : IEntityTypeConfiguration<AffairEmployeeDetail>
    {
        public void Configure(EntityTypeBuilder<AffairEmployeeDetail> builder)
        {
            builder.HasKey(ed => ed.EmployeeDetailId);
        }
    }
}
