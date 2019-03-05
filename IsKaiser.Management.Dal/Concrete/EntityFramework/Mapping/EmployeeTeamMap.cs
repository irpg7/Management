using IsKaiser.Management.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework.Mapping
{
    public class EmployeeTeamMap : IEntityTypeConfiguration<EmployeeTeam>
    {
        public void Configure(EntityTypeBuilder<EmployeeTeam> builder)
        {
            builder.HasKey(et => et.TeamId);
        }
    }
}
