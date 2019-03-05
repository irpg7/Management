using IsKaiser.Management.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework.Mapping
{
    public class AffairDetailMap : IEntityTypeConfiguration<AffairDetail>
    {
        public void Configure(EntityTypeBuilder<AffairDetail> builder)
        {
            builder.HasKey(ad => ad.AffairDetailId);
        }
    }
}
