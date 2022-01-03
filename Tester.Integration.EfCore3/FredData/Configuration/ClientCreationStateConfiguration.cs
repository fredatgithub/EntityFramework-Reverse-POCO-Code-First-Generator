// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore3
{
    // ClientCreationState
    public class ClientCreationStateConfiguration : IEntityTypeConfiguration<ClientCreationState>
    {
        public void Configure(EntityTypeBuilder<ClientCreationState> builder)
        {
            builder.ToTable("ClientCreationState", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__ClientCr__3213E83F95DD2206").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("uniqueidentifier").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.WebhookSetup).HasColumnName(@"WebhookSetup").HasColumnType("bit").IsRequired();
            builder.Property(x => x.AuthSetup).HasColumnName(@"AuthSetup").HasColumnType("bit").IsRequired();
            builder.Property(x => x.AssignedCarrier).HasColumnName(@"AssignedCarrier").HasColumnType("bit").IsRequired();
        }
    }

}
// </auto-generated>
