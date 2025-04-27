using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UnifiedContract.Domain.Entities.WorkOrder;

namespace UnifiedContract.Persistence.Configurations.WorkOrder
{
    public class WorkOrderConfiguration : IEntityTypeConfiguration<Domain.Entities.WorkOrder.WorkOrder>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.WorkOrder.WorkOrder> builder)
        {
            builder.ToTable("WorkOrders");

            builder.HasKey(wo => wo.Id);
            
            builder.Property(wo => wo.Title)
                .IsRequired()
                .HasMaxLength(200);
                
            builder.Property(wo => wo.Description)
                .HasMaxLength(2000);
                
            builder.Property(wo => wo.Status)
                .IsRequired()
                .HasMaxLength(50);
                
            builder.Property(wo => wo.Priority)
                .IsRequired()
                .HasMaxLength(20);
                
            builder.Property(wo => wo.Location)
                .HasMaxLength(200);
                
            builder.Property(wo => wo.EstimatedCost)
                .HasPrecision(18, 2);
                
            builder.Property(wo => wo.ActualCost)
                .HasPrecision(18, 2);
                
            builder.Property(wo => wo.Reference)
                .HasMaxLength(100);
                
            builder.Property(wo => wo.Category)
                .HasMaxLength(50);
                
            // Relationships
            builder.HasMany(wo => wo.WorkOrderItems)
                .WithOne()
                .HasForeignKey(woi => woi.WorkOrderId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasMany(wo => wo.WorkOrderPhotos)
                .WithOne()
                .HasForeignKey(wop => wop.WorkOrderId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasMany(wo => wo.WorkOrderRemarks)
                .WithOne()
                .HasForeignKey(wor => wor.WorkOrderId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasMany(wo => wo.WorkOrderTasks)
                .WithOne()
                .HasForeignKey(wot => wot.WorkOrderId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasMany(wo => wo.WorkOrderForms)
                .WithOne()
                .HasForeignKey(wof => wof.WorkOrderId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasMany(wo => wo.WorkOrderInvoices)
                .WithOne()
                .HasForeignKey(woi => woi.WorkOrderId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasMany(wo => wo.WorkOrderIssues)
                .WithOne()
                .HasForeignKey(woi => woi.WorkOrderId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasMany(wo => wo.WorkOrderActions)
                .WithOne()
                .HasForeignKey(woa => woa.WorkOrderId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasMany(wo => wo.WorkOrderExpenses)
                .WithOne()
                .HasForeignKey(woe => woe.WorkOrderId)
                .OnDelete(DeleteBehavior.Cascade);
                
            // Audit properties
            builder.Property(wo => wo.CreatedBy)
                .HasMaxLength(50);
                
            builder.Property(wo => wo.LastModifiedBy)
                .HasMaxLength(50);
        }
    }
} 