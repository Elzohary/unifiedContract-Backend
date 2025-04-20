using System;
using UnifiedContract.Domain.Common;

namespace UnifiedContract.Domain.Entities.HR
{
    public class WorkExperience : BaseEntity
    {
        public string Company { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public string ReferenceName { get; set; }
        public string ReferenceContact { get; set; }
        public Guid EmployeeId { get; set; }
    }
} 