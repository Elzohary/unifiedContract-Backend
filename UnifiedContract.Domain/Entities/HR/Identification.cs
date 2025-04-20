using System;
using UnifiedContract.Domain.Common;

namespace UnifiedContract.Domain.Entities.HR
{
    public class Identification : BaseEntity
    {
        public string Type { get; set; } // 'passport', 'id-card', 'driver-license', 'iqama', 'other'
        public string Number { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string IssuingCountry { get; set; }
        public string DocumentUrl { get; set; }
        public Guid EmployeeId { get; set; }
    }
} 