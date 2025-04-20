using System;
using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.Enums;

namespace UnifiedContract.Domain.Entities.WorkOrder
{
    public class WorkOrderTask : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public WorkOrderPriority Priority { get; set; }
        public TaskStatus Status { get; set; }
        public bool Completed { get; set; }
        public Guid WorkOrderId { get; set; }
        public Guid? ConfirmedById { get; set; }

        // Navigation properties will be defined in the configurations
    }
} 