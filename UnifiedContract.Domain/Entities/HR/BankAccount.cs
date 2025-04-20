using System;
using UnifiedContract.Domain.Common;

namespace UnifiedContract.Domain.Entities.HR
{
    public class BankAccount : BaseEntity
    {
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IBAN { get; set; }
        public string SwiftCode { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public bool IsPrimary { get; set; }
        public Guid EmployeeId { get; set; }
        
        // Navigation properties
        public virtual Employee Employee { get; set; }
    }
} 