using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UnifiedContract.Domain.Entities.Resource;
using UnifiedContract.Persistence.Configurations.Common;

namespace UnifiedContract.Persistence.Configurations.Resource
{
    public class EquipmentMaintenanceConfiguration : BaseEntityConfiguration<EquipmentMaintenance>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<EquipmentMaintenance> builder)
        {
            // Table name
            builder.ToTable("EquipmentMaintenance", "Resource");
            
            // Properties
            builder.Property(m => m.MaintenanceDate)
                .IsRequired();
                
            builder.Property(m => m.MaintenanceType)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(50);
                
            builder.Property(m => m.Description)
                .IsRequired()
                .HasMaxLength(1000);
                
            builder.Property(m => m.Cost)
                .HasColumnType("decimal(18,2)");
                
            builder.Property(m => m.Currency)
                .HasMaxLength(3)
                .HasDefaultValue("SAR");
                
            builder.Property(m => m.PerformedBy)
                .HasMaxLength(100);
                
            builder.Property(m => m.NextMaintenanceDate);
                
            builder.Property(m => m.Status)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(20);
                
            builder.Property(m => m.Notes)
                .HasMaxLength(1000);
            
            // Indexes
            builder.HasIndex(m => m.EquipmentId);
            builder.HasIndex(m => m.MaintenanceDate);
            builder.HasIndex(m => m.MaintenanceType);
            builder.HasIndex(m => m.Status);
            builder.HasIndex(m => m.NextMaintenanceDate);
            builder.HasIndex(m => new { m.EquipmentId, m.MaintenanceDate });
            
            // Relationships
            builder.HasOne(m => m.Equipment)
                .WithMany(e => e.MaintenanceHistory)
                .HasForeignKey(m => m.EquipmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 