using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.Entities.HR;

namespace UnifiedContract.Domain.Events.HR
{
    public class SalaryAddedEvent : DomainEvent
    {
        public Salary Salary { get; }

        public SalaryAddedEvent(Salary salary)
        {
            Salary = salary;
        }
    }

    public class SalaryUpdatedEvent : DomainEvent
    {
        public Salary Salary { get; }

        public SalaryUpdatedEvent(Salary salary)
        {
            Salary = salary;
        }
    }

    public class SalaryActivatedEvent : DomainEvent
    {
        public Salary Salary { get; }

        public SalaryActivatedEvent(Salary salary)
        {
            Salary = salary;
        }
    }

    public class SalaryDeactivatedEvent : DomainEvent
    {
        public Salary Salary { get; }

        public SalaryDeactivatedEvent(Salary salary)
        {
            Salary = salary;
        }
    }

    public class SalaryTerminatedEvent : DomainEvent
    {
        public Salary Salary { get; }

        public SalaryTerminatedEvent(Salary salary)
        {
            Salary = salary;
        }
    }
} 