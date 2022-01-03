// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore3
{
    // CMS_Tag
    public class CmsTagConfiguration : IEntityTypeConfiguration<CmsTag>
    {
        public void Configure(EntityTypeBuilder<CmsTag> builder)
        {
            builder.ToTable("CMS_Tag", "dbo");
            builder.HasKey(x => x.TagId).HasName("PK_CMS_Tag").IsClustered();

            builder.Property(x => x.TagId).HasColumnName(@"TagId").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.TagName).HasColumnName(@"TagName").HasColumnType("varchar(100)").IsRequired().IsUnicode(false).HasMaxLength(100);
        }
    }

}
// </auto-generated>
