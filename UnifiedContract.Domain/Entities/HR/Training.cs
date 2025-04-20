using System;
using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.Enums;

namespace UnifiedContract.Domain.Entities.HR
{
    public class Training : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Provider { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DurationHours { get; set; }
        public string Location { get; set; }
        public decimal Cost { get; set; }
        public string Currency { get; set; }
        public TrainingStatus Status { get; set; }
        public string CertificateUrl { get; set; }
        public int? Score { get; set; }
        public string Feedback { get; set; }
        public Guid EmployeeId { get; set; }
        
        // Navigation properties
        public virtual Employee Employee { get; set; }
    }
} 