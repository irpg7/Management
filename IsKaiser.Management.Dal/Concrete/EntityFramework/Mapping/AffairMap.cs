using IsKaiser.Management.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework.Mapping
{
    public class AffairMap : IEntityTypeConfiguration<Affair>
    {
        public void Configure(EntityTypeBuilder<Affair> builder)
        {
            builder.HasKey(a => a.AffairId);
        }
    }
}
