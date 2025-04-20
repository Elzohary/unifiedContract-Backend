using System;
using System.Collections.Generic;
using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.Enums;

namespace UnifiedContract.Domain.Entities.Auth
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public bool IsActive { get; set; }
        public UserRole Role { get; set; }
        public bool IsEmployee { get; set; }
        public Guid? EmployeeId { get; set; }

        // Navigation properties will be defined in the configurations
    }
} 