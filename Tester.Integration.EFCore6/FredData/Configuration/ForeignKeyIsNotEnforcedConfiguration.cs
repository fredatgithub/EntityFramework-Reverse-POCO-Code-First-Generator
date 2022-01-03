// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6Fred
{
    // ForeignKeyIsNotEnforced
    public class ForeignKeyIsNotEnforcedConfiguration : IEntityTypeConfiguration<ForeignKeyIsNotEnforced>
    {
        public void Configure(EntityTypeBuilder<ForeignKeyIsNotEnforced> builder)
        {
            builder.ToTable("ForeignKeyIsNotEnforced", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__ForeignK__3213E83F7A9FD04F").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.NullValue).HasColumnName(@"null_value").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.NotNullValue).HasColumnName(@"not_null_value").HasColumnType("int").IsRequired();

            builder.HasIndex(x => x.NotNullValue).HasDatabaseName("UQ_ForeignKeyIsNotEnforced_not_null_value").IsUnique();
            builder.HasIndex(x => x.NullValue).HasDatabaseName("UQ_ForeignKeyIsNotEnforced_null_value").IsUnique();
        }
    }

}
// </auto-generated>
