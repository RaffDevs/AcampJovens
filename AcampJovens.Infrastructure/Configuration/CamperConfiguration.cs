using AcampJovens.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcampJovens.Infrastructure.Configuration;

public class CamperConfiguration : IEntityTypeConfiguration<Camper>
{
    public void Configure(EntityTypeBuilder<Camper> builder)
    {
        builder.HasKey(p => p.Id);
    }
}