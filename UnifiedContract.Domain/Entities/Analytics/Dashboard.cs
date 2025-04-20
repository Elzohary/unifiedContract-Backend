using System;
using System.Collections.Generic;
using UnifiedContract.Domain.Common;

namespace UnifiedContract.Domain.Entities.Analytics
{
    public class Dashboard : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Module { get; set; } // WorkOrder, HR, Resource, etc.
        public bool IsDefault { get; set; }
        public bool IsSystem { get; set; }
        public bool IsPublic { get; set; }
        public Guid? OwnerId { get; set; }
        
        // Navigation properties
        public virtual User Owner { get; set; }
        public virtual ICollection<DashboardWidget> Widgets { get; set; }
        public virtual ICollection<DashboardUser> DashboardUsers { get; set; }
        
        public Dashboard()
        {
            Widgets = new HashSet<DashboardWidget>();
            DashboardUsers = new HashSet<DashboardUser>();
        }
    }
} 