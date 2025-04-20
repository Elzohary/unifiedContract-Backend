using System;
using UnifiedContract.Domain.Common;

namespace UnifiedContract.Domain.Entities.HR
{
    public class Certificate : BaseEntity
    {
        public string Name { get; set; }
        public string Issuer { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string DocumentUrl { get; set; }
        public bool Verified { get; set; }
        public Guid EmployeeId { get; set; }
    }
} 