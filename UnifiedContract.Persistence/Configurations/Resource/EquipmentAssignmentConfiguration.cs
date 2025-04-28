using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UnifiedContract.Domain.Entities.Resource;
using UnifiedContract.Persistence.Configurations.Common;

namespace UnifiedContract.Persistence.Configurations.Resource
{
    public class EquipmentAssignmentConfiguration : BaseEntityConfiguration<EquipmentAssignment>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<EquipmentAssignment> builder)
        {
            // Table name
            builder.ToTable("EquipmentAssignment", "Resource");
            
            // Properties
            builder.Property(a => a.AssignmentDate)
                .IsRequired();
                
            builder.Property(a => a.ReturnDate);
                
            builder.Property(a => a.AssignedTo)
                .IsRequired()
                .HasMaxLength(100);
                
            builder.Property(a => a.Department)
                .HasMaxLength(100);
                
            builder.Property(a => a.Location)
                .HasMaxLength(200);
                
            builder.Property(a => a.Purpose)
                .HasMaxLength(500);
                
            builder.Property(a => a.Status)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(20);
                
            builder.Property(a => a.Notes)
                .HasMaxLength(1000);
            
            // Indexes
            builder.HasIndex(a => a.EquipmentId);
            builder.HasIndex(a => a.AssignmentDate);
            builder.HasIndex(a => a.ReturnDate);
            builder.HasIndex(a => a.Status);
            builder.HasIndex(a => a.AssignedTo);
            builder.HasIndex(a => new { a.EquipmentId, a.Status });
            builder.HasIndex(a => new { a.AssignedTo, a.Status });
            
            // Relationships
            builder.HasOne(a => a.Equipment)
                .WithMany(e => e.Assignments)
                .HasForeignKey(a => a.EquipmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
} 