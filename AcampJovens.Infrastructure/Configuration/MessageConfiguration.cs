using AcampJovens.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcampJovens.Infrastructure.Configuration;

public class MessageConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.HasKey(p => p.Id);

        builder
            .HasOne(p => p.AudioFile)
            .WithOne(p => p.Message)
            .OnDelete(DeleteBehavior.Cascade);
    }
}