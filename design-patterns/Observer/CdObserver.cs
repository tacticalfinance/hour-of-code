using design_patterns.Observer.contracts;

namespace design_patterns.Observer;

public class CdObserver(string cdTitle) : AbstractStoreObserver
{
    public override void Update(ISubject subject)
    {
        NewArrival = subject is IStoreSubject store &&
                     store.NewArrival != null &&
                     store.NewArrival.Type == InventoryType.Cd &&
                     store.NewArrival.Title == cdTitle
            ? store.NewArrival
            : null;
    }
}