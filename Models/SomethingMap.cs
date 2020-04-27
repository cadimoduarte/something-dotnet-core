using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SomethingWebApi.Models
{
    public class SomethingMap : IEntityTypeConfiguration<Something>
    {
        public void Configure(EntityTypeBuilder<Something> builder)
        {
            builder.Property(c => c.Id)
                //.HasDefaultValueSql("nextval('something_seq')");
                  .HasDefaultValueSql("NEXT VALUE FOR something_seq");
            builder.ToTable("something");
        }
    }
}
