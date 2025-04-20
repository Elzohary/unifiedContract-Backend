using System;
using System.Collections.Generic;
using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.Enums;
using UnifiedContract.Domain.ValueObjects;

namespace UnifiedContract.Domain.Entities.HR
{
    public class Salary : BaseEntity
    {
        public decimal BasicSalary { get; set; }
        public string Currency { get; set; }
        public PaymentFrequency Frequency { get; set; }
        public decimal TotalAllowances { get; set; }
        public decimal TotalDeductions { get; set; }
        public decimal NetSalary { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Notes { get; set; }
        public Guid EmployeeId { get; set; }
        
        // Navigation properties
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Allowance> Allowances { get; set; }
        public virtual ICollection<Deduction> Deductions { get; set; }
        
        public Salary()
        {
            Allowances = new HashSet<Allowance>();
            Deductions = new HashSet<Deduction>();
        }
    }
} 