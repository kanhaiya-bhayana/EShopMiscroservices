namespace Ordering.Domain.Abstractions;
public abstract class Aggregate<Tid> : Entity<Tid>, IAggregate<Tid>
{
    private readonly List<IDomainEvent> _domainEvents = new();

    public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();


    public void AddDoaminEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public void RemoveDoaminEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Remove(domainEvent);
    }

    public IDomainEvent[] ClearDomainEvent()
    {
        IDomainEvent[] dequeuedEvents  = _domainEvents.ToArray();
        _domainEvents.Clear();
        return dequeuedEvents;
    }
}
