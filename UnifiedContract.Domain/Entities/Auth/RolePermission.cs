using System;
using UnifiedContract.Domain.Common;

namespace UnifiedContract.Domain.Entities.Auth
{
    public class RolePermission : BaseEntity
    {
        public Guid RoleId { get; set; }
        public Guid PermissionId { get; set; }
        
        // Navigation properties
        public virtual Role Role { get; set; }
        public virtual Permission Permission { get; set; }
    }
} 