using IsKaiser.Management.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework.Mapping
{
    public class CompanyInformationMap : IEntityTypeConfiguration<CompanyInformation>
    {
        public void Configure(EntityTypeBuilder<CompanyInformation> builder)
        {
            builder.HasKey(ci => ci.Id);
        }
    }
}
