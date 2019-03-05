using IsKaiser.Management.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework.Mapping
{
    public class CustomerDirectorMap : IEntityTypeConfiguration<CustomerDirector>
    {
        public void Configure(EntityTypeBuilder<CustomerDirector> builder)
        {
            builder.HasKey(cd => cd.DirectorId);
        }
    }
}
