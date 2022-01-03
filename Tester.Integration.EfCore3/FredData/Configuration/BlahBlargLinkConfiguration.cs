// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore3
{
    // BlahBlargLink
    public class BlahBlargLinkConfiguration : IEntityTypeConfiguration<BlahBlargLink>
    {
        public void Configure(EntityTypeBuilder<BlahBlargLink> builder)
        {
            builder.ToTable("BlahBlargLink", "dbo");
            builder.HasKey(x => new { x.BlahId, x.BlargId }).HasName("PK_BlahBlargLink").IsClustered();

            builder.Property(x => x.BlahId).HasColumnName(@"BlahID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.BlargId).HasColumnName(@"BlargID").HasColumnType("int").IsRequired().ValueGeneratedNever();

            // Foreign keys
            builder.HasOne(a => a.Blah).WithMany(b => b.BlahBlargLinks).HasForeignKey(c => c.BlahId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_BlahBlargLink_Blah");
            builder.HasOne(a => a.Blarg).WithMany(b => b.BlahBlargLinks).HasForeignKey(c => c.BlargId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_BlahBlargLink_Blarg");
        }
    }

}
// </auto-generated>
