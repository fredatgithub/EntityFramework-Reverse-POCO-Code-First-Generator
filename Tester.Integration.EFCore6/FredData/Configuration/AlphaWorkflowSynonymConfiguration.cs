// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6Fred
{
    // alpha_workflow_synonym
    public class AlphaWorkflowSynonymConfiguration : IEntityTypeConfiguration<AlphaWorkflowSynonym>
    {
        public void Configure(EntityTypeBuilder<AlphaWorkflowSynonym> builder)
        {
            builder.ToTable("alpha_workflow_synonym", "dbo");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Description).HasColumnName(@"Description").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>
