using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using ToDo.Domain.DBModel;

namespace ToDo.Infrastructure.Configuration
{
    public class ToDoConficutation : IEntityTypeConfiguration<TODO>
    {
        public void Configure(EntityTypeBuilder<TODO> builder)
        {
            builder.Property(x => x.Status)
                .IsRequired();
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(250);
            builder.Property(x => x.Description)
                .IsRequired(false)
                .HasMaxLength(500);
            builder.Property(x => x.UserId)
                .IsRequired();
        }
    }
}