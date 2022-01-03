// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6Fred
{
    // hierarchy_test
    public class HierarchyTestConfiguration : IEntityTypeConfiguration<HierarchyTest>
    {
        public void Configure(EntityTypeBuilder<HierarchyTest> builder)
        {
            builder.ToTable("hierarchy_test", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__hierarch__3214EC27A00D9B63").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Hid).HasColumnName(@"hid").HasColumnType("hierarchyid").IsRequired();
        }
    }

}
// </auto-generated>
