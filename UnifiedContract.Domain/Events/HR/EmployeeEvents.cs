using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.Entities.HR;

namespace UnifiedContract.Domain.Events.HR
{
    public class EmployeeCreatedEvent : DomainEvent
    {
        public Employee Employee { get; }

        public EmployeeCreatedEvent(Employee employee)
        {
            Employee = employee;
        }
    }

    public class EmployeeDepartmentChangedEvent : DomainEvent
    {
        public Employee Employee { get; }

        public EmployeeDepartmentChangedEvent(Employee employee)
        {
            Employee = employee;
        }
    }

    public class EmployeeManagerChangedEvent : DomainEvent
    {
        public Employee Employee { get; }

        public EmployeeManagerChangedEvent(Employee employee)
        {
            Employee = employee;
        }
    }

    public class EmployeeContactInfoUpdatedEvent : DomainEvent
    {
        public Employee Employee { get; }

        public EmployeeContactInfoUpdatedEvent(Employee employee)
        {
            Employee = employee;
        }
    }

    public class EmployeeJobInfoUpdatedEvent : DomainEvent
    {
        public Employee Employee { get; }

        public EmployeeJobInfoUpdatedEvent(Employee employee)
        {
            Employee = employee;
        }
    }

    public class EmployeeSalaryUpdatedEvent : DomainEvent
    {
        public Employee Employee { get; }

        public EmployeeSalaryUpdatedEvent(Employee employee)
        {
            Employee = employee;
        }
    }
} 