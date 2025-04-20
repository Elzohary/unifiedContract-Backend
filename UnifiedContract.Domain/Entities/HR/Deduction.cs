using System;
using UnifiedContract.Domain.Common;

namespace UnifiedContract.Domain.Entities.HR
{
    public class Deduction : BaseEntity
    {
        public string Type { get; set; } // Tax, Insurance, Loan, etc.
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public bool IsMandatory { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid SalaryId { get; set; }
        
        // Navigation properties
        public virtual Salary Salary { get; set; }
    }
} 