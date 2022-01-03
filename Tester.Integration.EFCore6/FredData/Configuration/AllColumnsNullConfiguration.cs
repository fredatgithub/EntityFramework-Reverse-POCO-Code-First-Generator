// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6Fred
{
    // AllColumnsNull
    public class AllColumnsNullConfiguration : IEntityTypeConfiguration<AllColumnsNull>
    {
        public void Configure(EntityTypeBuilder<AllColumnsNull> builder)
        {
            builder.ToView("AllColumnsNull", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.Total).HasColumnName(@"total").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.AName).HasColumnName(@"aName").HasColumnType("nvarchar(250)").IsRequired(false).HasMaxLength(250);
        }
    }

}
// </auto-generated>
