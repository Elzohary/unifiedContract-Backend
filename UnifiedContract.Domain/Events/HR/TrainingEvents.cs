using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.Entities.HR;

namespace UnifiedContract.Domain.Events.HR
{
    public class TrainingAddedEvent : DomainEvent
    {
        public Training Training { get; }

        public TrainingAddedEvent(Training training)
        {
            Training = training;
        }
    }

    public class TrainingUpdatedEvent : DomainEvent
    {
        public Training Training { get; }

        public TrainingUpdatedEvent(Training training)
        {
            Training = training;
        }
    }

    public class TrainingStartedEvent : DomainEvent
    {
        public Training Training { get; }

        public TrainingStartedEvent(Training training)
        {
            Training = training;
        }
    }

    public class TrainingCompletedEvent : DomainEvent
    {
        public Training Training { get; }

        public TrainingCompletedEvent(Training training)
        {
            Training = training;
        }
    }

    public class TrainingCancelledEvent : DomainEvent
    {
        public Training Training { get; }

        public TrainingCancelledEvent(Training training)
        {
            Training = training;
        }
    }

    public class TrainingFailedEvent : DomainEvent
    {
        public Training Training { get; }

        public TrainingFailedEvent(Training training)
        {
            Training = training;
        }
    }

    public class TrainingFeedbackAddedEvent : DomainEvent
    {
        public Training Training { get; }

        public TrainingFeedbackAddedEvent(Training training)
        {
            Training = training;
        }
    }

    public class TrainingCertificateAddedEvent : DomainEvent
    {
        public Training Training { get; }

        public TrainingCertificateAddedEvent(Training training)
        {
            Training = training;
        }
    }

    public class TrainingScoreUpdatedEvent : DomainEvent
    {
        public Training Training { get; }

        public TrainingScoreUpdatedEvent(Training training)
        {
            Training = training;
        }
    }
} 