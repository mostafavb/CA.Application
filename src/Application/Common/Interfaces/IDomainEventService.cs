using CA.Application.Domain.Common;

namespace CA.Application.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
