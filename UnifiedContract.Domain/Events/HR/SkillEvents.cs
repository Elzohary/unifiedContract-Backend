using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.Entities.HR;

namespace UnifiedContract.Domain.Events.HR
{
    public class SkillCreatedEvent : DomainEvent
    {
        public Skill Skill { get; }

        public SkillCreatedEvent(Skill skill)
        {
            Skill = skill;
        }
    }

    public class SkillUpdatedEvent : DomainEvent
    {
        public Skill Skill { get; }

        public SkillUpdatedEvent(Skill skill)
        {
            Skill = skill;
        }
    }
} 