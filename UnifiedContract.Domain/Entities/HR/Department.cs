using System;
using System.Collections.Generic;
using UnifiedContract.Domain.Common;

namespace UnifiedContract.Domain.Entities.HR
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid? ManagerId { get; set; }
        public Guid? ParentDepartmentId { get; set; }
        
        // Navigation properties
        public virtual Employee Manager { get; set; }
        public virtual Department ParentDepartment { get; set; }
        public virtual ICollection<Department> ChildDepartments { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        
        public Department()
        {
            ChildDepartments = new HashSet<Department>();
            Employees = new HashSet<Employee>();
        }
    }
} 