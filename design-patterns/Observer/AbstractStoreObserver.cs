using design_patterns.Observer.contracts;

namespace design_patterns.Observer;

public abstract class AbstractStoreObserver : IStoreObserver
{
    public abstract void Update(ISubject subject);
    public INewArrival? NewArrival { get; protected set; }
}