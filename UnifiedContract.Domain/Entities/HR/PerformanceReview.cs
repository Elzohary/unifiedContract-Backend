using System;
using UnifiedContract.Domain.Common;

namespace UnifiedContract.Domain.Entities.HR
{
    public class PerformanceReview : BaseEntity
    {
        public DateTime ReviewDate { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public int OverallScore { get; set; } // 1-5 or 1-10
        public string Comments { get; set; }
        public string Strengths { get; set; }
        public string AreasOfImprovement { get; set; }
        public string Goals { get; set; }
        public string TrainingNeeds { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid ReviewedById { get; set; }
        public bool Acknowledged { get; set; }
        public DateTime? AcknowledgedDate { get; set; }
        
        // Navigation properties
        public virtual Employee Employee { get; set; }
        public virtual Employee ReviewedBy { get; set; }
    }
} 