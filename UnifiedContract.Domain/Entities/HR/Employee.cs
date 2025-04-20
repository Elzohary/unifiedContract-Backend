using System;
using System.Collections.Generic;
using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.ValueObjects;

namespace UnifiedContract.Domain.Entities.HR
{
    public class Employee : BaseEntity
    {
        public string BadgeNumber { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string JobTitle { get; set; }
        public string WorkLocation { get; set; }
        public Address HomeAddress { get; set; }
        public string HomeType { get; set; } // 'company' or 'personal'
        public string CompanyPhone { get; set; }
        public string PersonalPhone { get; set; }
        public string IqamaNumber { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public Guid? DirectManagerId { get; set; }
        public decimal WorkTimeRatio { get; set; } // Percentage of expected work hours fulfilled
        public decimal MonthlyHours { get; set; } // Expected monthly hours
        public decimal AvgLateMinutes { get; set; }
        public DateTime JoinDate { get; set; }
        public string CurrentProject { get; set; }
        public int SickLeaveCounter { get; set; }
        public int OffDays { get; set; } // Remaining vacation days
        public Money Salary { get; set; }
        public Guid? UserId { get; set; }
    }
} 