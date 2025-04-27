using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UnifiedContract.Domain.Entities.WorkOrder;

namespace UnifiedContract.Persistence.Configurations.WorkOrder
{
    public class WorkOrderItemConfiguration : IEntityTypeConfiguration<WorkOrderItem>
    {
        public void Configure(EntityTypeBuilder<WorkOrderItem> builder)
        {
            builder.ToTable("WorkOrderItems");

            builder.HasKey(item => item.Id);
            
            builder.Property(item => item.Name)
                .IsRequired()
                .HasMaxLength(200);
                
            builder.Property(item => item.Description)
                .HasMaxLength(1000);
                
            builder.Property(item => item.UnitPrice)
                .HasPrecision(18, 2);
                
            builder.Property(item => item.Quantity)
                .HasPrecision(18, 2);
                
            builder.Property(item => item.UnitOfMeasure)
                .HasMaxLength(50);
                
            builder.Property(item => item.ItemType)
                .HasMaxLength(50);
                
            // Relationships
            builder.HasOne<Domain.Entities.WorkOrder.WorkOrder>()
                .WithMany(wo => wo.WorkOrderItems)
                .HasForeignKey(item => item.WorkOrderId)
                .OnDelete(DeleteBehavior.Cascade);
                
            // Audit properties
            builder.Property(item => item.CreatedBy)
                .HasMaxLength(50);
                
            builder.Property(item => item.LastModifiedBy)
                .HasMaxLength(50);
        }
    }
} 