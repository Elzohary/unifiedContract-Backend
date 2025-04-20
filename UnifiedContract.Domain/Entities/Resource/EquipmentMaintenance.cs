using System;
using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.Entities.HR;
using UnifiedContract.Domain.Entities.Resource.Lookups;

namespace UnifiedContract.Domain.Entities.Resource
{
    public class EquipmentMaintenance : BaseEntity
    {
        public string Description { get; set; }
        public DateTime ScheduledDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public decimal Cost { get; set; }
        public string Currency { get; set; }
        public string Notes { get; set; }
        public string ServiceProvider { get; set; }
        public string InvoiceNumber { get; set; }
        public string DocumentUrl { get; set; }
        
        // Foreign keys to lookup tables
        public Guid MaintenanceTypeId { get; set; }
        public Guid MaintenanceStatusId { get; set; }
        public Guid EquipmentId { get; set; }
        public Guid? PerformedById { get; set; }
        
        // Navigation properties
        public virtual MaintenanceType Type { get; set; }
        public virtual MaintenanceStatus Status { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual Employee PerformedBy { get; set; }
    }
} 