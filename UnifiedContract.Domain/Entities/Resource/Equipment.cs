using System;
using System.Collections.Generic;
using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.Enums;

namespace UnifiedContract.Domain.Entities.Resource
{
    public class Equipment : BaseEntity
    {
        public string CompanyNumber { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string Manufacturer { get; set; }
        public decimal DailyCost { get; set; }
        public string Currency { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime? LastMaintenanceDate { get; set; }
        public DateTime? NextMaintenanceDate { get; set; }
        public string Status { get; set; } // Available, InUse, UnderMaintenance, Damaged, Retired
        public string CurrentLocation { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid? CurrentOperatorId { get; set; }
        
        // Navigation properties
        public virtual Employee CurrentOperator { get; set; }
        public virtual ICollection<EquipmentAssignment> Assignments { get; set; }
        public virtual ICollection<EquipmentMaintenance> MaintenanceRecords { get; set; }
        
        public Equipment()
        {
            Assignments = new HashSet<EquipmentAssignment>();
            MaintenanceRecords = new HashSet<EquipmentMaintenance>();
        }
    }
} 