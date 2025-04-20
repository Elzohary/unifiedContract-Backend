using System;
using UnifiedContract.Domain.Common;

namespace UnifiedContract.Domain.Entities.Resource
{
    public class EquipmentAssignment : BaseEntity
    {
        public string CompanyNumber { get; set; }
        public string Type { get; set; }
        public string OperatorBadgeNumber { get; set; }
        public int HoursAssigned { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Notes { get; set; }
        public string WorkOrderNumber { get; set; }
        public Guid WorkOrderId { get; set; }

        // Navigation properties will be defined in the configurations
    }
} 