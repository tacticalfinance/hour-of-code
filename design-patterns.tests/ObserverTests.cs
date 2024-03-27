using System.Data;
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