using design_patterns.Observer;
using design_patterns.Observer.contracts;
using Xunit;

namespace design_patterns.tests;

public class ObserverTests
{
    private string _lastCustomerName = string.Empty;
    private string _lastTitle = string.Empty;


    [Fact]
    public void TestTrivialSolution()
    {
        IStore store = new TrivialStore();
        store.Notification += OnStoreNotification;

        store.AddCustomerInterest("David", InventoryType.Book, "Book Title 1");
        store.AddCustomerInterest("Josef", InventoryType.Cd, "CD Title 1");

        Clear();
        store.AddNewItem(new NewArrival("Book Title 1", InventoryType.Book));
        Assert.Equal("David", _lastCustomerName);
        Assert.Equal("Book Title 1", _lastTitle);

        Clear();
        store.AddNewItem(new NewArrival("CD Title 1", InventoryType.Cd));
        Assert.Equal("Josef", _lastCustomerName);
        Assert.Equal("CD Title 1", _lastTitle);

        Clear();
        store.AddNewItem(new NewArrival("Book Title 2", InventoryType.Book));
        Assert.Empty(_lastCustomerName);
        Assert.Empty(_lastTitle);

        Clear();
        store.AddNewItem(new NewArrival("CD Title 2", InventoryType.Cd));
        Assert.Empty(_lastCustomerName);
        Assert.Empty(_lastTitle);
    }

    [Fact]
    public void TestObserverSolution()
    {
        IStoreObserver david = new BookObserver("Book Title 1");
        IStoreObserver josef = new CdObserver("CD Title 1");

        IStoreSubject storeSubject = new StoreSubject();
        storeSubject.Attach(david);
        storeSubject.Attach(josef);

        storeSubject.NewArrival = new NewArrival("Book Title 2", InventoryType.Book);
        Assert.Null(david.NewArrival);
        Assert.Null(josef.NewArrival);

        storeSubject.NewArrival = new NewArrival("Book Title 3", InventoryType.Book);
        Assert.Null(david.NewArrival);
        Assert.Null(josef.NewArrival);

        storeSubject.NewArrival = new NewArrival("CD Title 2", InventoryType.Cd);
        Assert.Null(david.NewArrival);
        Assert.Null(josef.NewArrival);

        storeSubject.NewArrival = new NewArrival("CD Title 3", InventoryType.Cd);
        Assert.Null(david.NewArrival);
        Assert.Null(josef.NewArrival);

        storeSubject.NewArrival = new NewArrival("CD Title 1", InventoryType.Cd);
        Assert.NotNull(josef.NewArrival);
        Assert.Null(david.NewArrival);
        Assert.Equal("CD Title 1", josef.NewArrival.Title);
        Assert.Equal(InventoryType.Cd, josef.NewArrival.Type);

        storeSubject.NewArrival = new NewArrival("Book Title 1", InventoryType.Book);
        Assert.NotNull(david.NewArrival);
        Assert.Equal("Book Title 1", david.NewArrival.Title);
        Assert.Equal(InventoryType.Book, david.NewArrival.Type);
        Assert.Null(josef.NewArrival);

        var oldArrival = david.NewArrival;
        storeSubject.Detach(david);

        storeSubject.NewArrival = new NewArrival("Book Title 1", InventoryType.Book);
        Assert.Same(oldArrival, david.NewArrival);

        storeSubject.Attach(david);

        storeSubject.NewArrival = new NewArrival("Book Title 1", InventoryType.Book);
        Assert.NotSame(oldArrival, david.NewArrival);
        Assert.Equal("Book Title 1", david.NewArrival.Title);
        Assert.Equal(InventoryType.Book, david.NewArrival.Type);
    }

    private void Clear()
    {
        _lastCustomerName = string.Empty;
        _lastTitle = string.Empty;
    }

    private void OnStoreNotification(string customerName, string title)
    {
        _lastCustomerName = customerName;
        _lastTitle = title;
    }
}