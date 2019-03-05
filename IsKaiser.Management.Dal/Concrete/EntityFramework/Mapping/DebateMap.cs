using IsKaiser.Management.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework.Mapping
{
    public class DebateMap : IEntityTypeConfiguration<Debate>
    {
        public void Configure(EntityTypeBuilder<Debate> builder)
        {
            builder.HasKey(d => d.DebateId);
        }
    }
}
