// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6Fred
{
    // Бренды товара
    public class БрендытовараConfiguration : IEntityTypeConfiguration<Брендытовара>
    {
        public void Configure(EntityTypeBuilder<Брендытовара> builder)
        {
            builder.ToTable("Бренды товара", "dbo");
            builder.HasKey(x => x.Кодбренда).HasName("PK_Бренды").IsClustered();

            builder.Property(x => x.Кодбренда).HasColumnName(@"Код бренда").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Наименованиебренда).HasColumnName(@"Наименование бренда").HasColumnType("varchar(50)").IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Логотипбренда).HasColumnName(@"Логотип_бренда").HasColumnType("image(2147483647)").IsRequired(false).HasMaxLength(2147483647);
            builder.Property(x => x.Логотипбрендавертикальный).HasColumnName(@"Логотип_бренда_вертикальный").HasColumnType("image(2147483647)").IsRequired(false).HasMaxLength(2147483647);
        }
    }

}
// </auto-generated>
