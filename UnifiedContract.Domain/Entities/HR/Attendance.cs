using System;
using UnifiedContract.Domain.Common;

namespace UnifiedContract.Domain.Entities.HR
{
    public class Attendance : BaseEntity
    {
        public DateTime Date { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }
        public int TotalMinutes { get; set; }
        public int LateMinutes { get; set; }
        public int OvertimeMinutes { get; set; }
        public bool IsAbsent { get; set; }
        public bool IsHalfDay { get; set; }
        public bool IsLeave { get; set; }
        public bool IsHoliday { get; set; }
        public string Notes { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid? WorkOrderId { get; set; }
        public string Location { get; set; }
        
        // Navigation properties
        public virtual Employee Employee { get; set; }
        public virtual WorkOrder.WorkOrder WorkOrder { get; set; }
    }
} 