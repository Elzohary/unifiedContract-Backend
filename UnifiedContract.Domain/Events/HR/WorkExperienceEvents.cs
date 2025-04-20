using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.Entities.HR;

namespace UnifiedContract.Domain.Events.HR
{
    public class WorkExperienceAddedEvent : DomainEvent
    {
        public WorkExperience WorkExperience { get; }

        public WorkExperienceAddedEvent(WorkExperience workExperience)
        {
            WorkExperience = workExperience;
        }
    }

    public class WorkExperienceUpdatedEvent : DomainEvent
    {
        public WorkExperience WorkExperience { get; }

        public WorkExperienceUpdatedEvent(WorkExperience workExperience)
        {
            WorkExperience = workExperience;
        }
    }

    public class WorkExperienceSetAsCurrentEvent : DomainEvent
    {
        public WorkExperience WorkExperience { get; }

        public WorkExperienceSetAsCurrentEvent(WorkExperience workExperience)
        {
            WorkExperience = workExperience;
        }
    }

    public class WorkExperienceSetAsFormerEvent : DomainEvent
    {
        public WorkExperience WorkExperience { get; }

        public WorkExperienceSetAsFormerEvent(WorkExperience workExperience)
        {
            WorkExperience = workExperience;
        }
    }
} 