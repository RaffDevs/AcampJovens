using AcampJovens.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcampJovens.Infrastructure.Configuration;

public class AudioConfiguration : IEntityTypeConfiguration<Audio>
{
    public void Configure(EntityTypeBuilder<Audio> builder)
    {
        builder.HasKey(p => p.Id);
        builder
            .Property(p => p.AudioBase64)
            .HasColumnType("TEXT");
        builder
            .HasOne(p => p.Message)
            .WithOne(p => p.AudioFile)
            .HasForeignKey<Audio>(p => p.MessageId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}