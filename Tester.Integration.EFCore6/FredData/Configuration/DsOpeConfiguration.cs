// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6Fred
{
    // DSOpe
    public class DsOpeConfiguration : IEntityTypeConfiguration<DsOpe>
    {
        public void Configure(EntityTypeBuilder<DsOpe> builder)
        {
            builder.ToTable("DSOpe", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__DSOpe__3214EC27150C693D").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DecimalDefault).HasColumnName(@"decimal_default").HasColumnType("decimal(15,2)").HasPrecision(15,2).IsRequired();
            builder.Property(x => x.MyGuid).HasColumnName(@"MyGuid").HasColumnType("uniqueidentifier").IsRequired();
            builder.Property(x => x.@Default).HasColumnName(@"default").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.MyGuidBadDefault).HasColumnName(@"MyGuidBadDefault").HasColumnType("uniqueidentifier").IsRequired(false);
        }
    }

}
// </auto-generated>
