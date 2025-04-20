using System;
using UnifiedContract.Domain.Common;

namespace UnifiedContract.Domain.Entities.Resource
{
    public class PurchasableMaterial : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? TotalCost { get; set; }
        public string Status { get; set; }
        public string Supplier { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }

        // Navigation properties will be defined in the configurations
    }
} 