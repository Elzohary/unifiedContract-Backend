using System;
using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.Enums;

namespace UnifiedContract.Domain.Entities.Resource
{
    public class EquipmentMaintenance : BaseEntity
    {
        public string MaintenanceType { get; set; } // Routine, Repair, Inspection, Emergency
        public string Description { get; set; }
        public DateTime ScheduledDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public decimal Cost { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; } // Scheduled, InProgress, Completed, Cancelled
        public string Notes { get; set; }
        public string ServiceProvider { get; set; }
        public string InvoiceNumber { get; set; }
        public string DocumentUrl { get; set; }
        public Guid EquipmentId { get; set; }
        public Guid? PerformedById { get; set; }
        
        // Navigation properties
        public virtual Equipment Equipment { get; set; }
        public virtual Employee PerformedBy { get; set; }
    }
} 