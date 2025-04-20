using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.Entities.HR;

namespace UnifiedContract.Domain.Events.HR
{
    public class DepartmentCreatedEvent : DomainEvent
    {
        public Department Department { get; }

        public DepartmentCreatedEvent(Department department)
        {
            Department = department;
        }
    }

    public class DepartmentUpdatedEvent : DomainEvent
    {
        public Department Department { get; }

        public DepartmentUpdatedEvent(Department department)
        {
            Department = department;
        }
    }

    public class DepartmentActivatedEvent : DomainEvent
    {
        public Department Department { get; }

        public DepartmentActivatedEvent(Department department)
        {
            Department = department;
        }
    }

    public class DepartmentDeactivatedEvent : DomainEvent
    {
        public Department Department { get; }

        public DepartmentDeactivatedEvent(Department department)
        {
            Department = department;
        }
    }

    public class DepartmentManagerAssignedEvent : DomainEvent
    {
        public Department Department { get; }

        public DepartmentManagerAssignedEvent(Department department)
        {
            Department = department;
        }
    }

    public class DepartmentHierarchyChangedEvent : DomainEvent
    {
        public Department Department { get; }

        public DepartmentHierarchyChangedEvent(Department department)
        {
            Department = department;
        }
    }

    public class DepartmentBudgetUpdatedEvent : DomainEvent
    {
        public Department Department { get; }

        public DepartmentBudgetUpdatedEvent(Department department)
        {
            Department = department;
        }
    }

    public class DepartmentHeadCountUpdatedEvent : DomainEvent
    {
        public Department Department { get; }

        public DepartmentHeadCountUpdatedEvent(Department department)
        {
            Department = department;
        }
    }
} 