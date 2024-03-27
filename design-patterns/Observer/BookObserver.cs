using design_patterns.Observer.contracts;

namespace design_patterns.Observer;

public class BookObserver(string bookTitle) : AbstractStoreObserver
{
    public override void Update(ISubject subject)
    {
        NewArrival = subject is IStoreSubject store &&
                     store.NewArrival != null &&
                     store.NewArrival.Type == InventoryType.Book &&
                     store.NewArrival.Title == bookTitle
            ? store.NewArrival
            : null;
    }
}