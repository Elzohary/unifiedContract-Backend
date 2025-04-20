using System;
using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.ValueObjects;

namespace UnifiedContract.Domain.Entities.HR
{
    public class EmergencyContact : BaseEntity
    {
        public string Name { get; set; }
        public string Relationship { get; set; }
        public string PrimaryPhone { get; set; }
        public string SecondaryPhone { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public Guid EmployeeId { get; set; }
    }
} 