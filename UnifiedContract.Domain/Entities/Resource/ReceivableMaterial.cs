using System;
using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.Enums;

namespace UnifiedContract.Domain.Entities.Resource
{
    public class ReceivableMaterial : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public decimal EstimatedQuantity { get; set; }
        public decimal? ReceivedQuantity { get; set; }
        public decimal? ActualQuantity { get; set; }
        public decimal? RemainingQuantity { get; set; }
        public decimal? ReturnedQuantity { get; set; }
        public MaterialStatus Status { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public Guid? ReceivedById { get; set; }
        public Guid? ReturnedById { get; set; }

        // Navigation properties will be defined in the configurations
    }
} 