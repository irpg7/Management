using IsKaiser.Management.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework.Mapping
{
    public class AffairVehicleDetailMap : IEntityTypeConfiguration<AffairVehicleDetail>
    {
        public void Configure(EntityTypeBuilder<AffairVehicleDetail> builder)
        {
            builder.HasKey(vd => vd.VehicleDetailId);
        }
    }
}
