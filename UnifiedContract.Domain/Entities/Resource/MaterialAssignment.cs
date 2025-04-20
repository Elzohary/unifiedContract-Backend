using System;
using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.Enums;

namespace UnifiedContract.Domain.Entities.Resource
{
    public class MaterialAssignment : BaseEntity
    {
        public MaterialType MaterialType { get; set; }
        public Guid? PurchasableMaterialId { get; set; }
        public Guid? ReceivableMaterialId { get; set; }
        public string WorkOrderNumber { get; set; }
        public Guid? WorkOrderId { get; set; }
        public DateTime AssignDate { get; set; }
        public Guid AssignedById { get; set; }
        public string StoringLocation { get; set; }

        // Navigation properties will be defined in the configurations
    }
} 