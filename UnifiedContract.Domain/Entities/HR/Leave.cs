using System;
using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.Enums;

namespace UnifiedContract.Domain.Entities.HR
{
    public class Leave : BaseEntity
    {
        public LeaveType Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalDays { get; set; }
        public string Reason { get; set; }
        public LeaveStatus Status { get; set; }
        public string Comments { get; set; }
        public string DocumentUrl { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid? ApprovedById { get; set; }
        public DateTime? ApprovedDate { get; set; }
        
        // Navigation properties
        public virtual Employee Employee { get; set; }
        public virtual Employee ApprovedBy { get; set; }
    }
} 