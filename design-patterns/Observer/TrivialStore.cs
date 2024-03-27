using design_patterns.Observer.contracts;

namespace design_patterns.Observer;

public class TrivialStore : IStore
{
    private readonly Dictionary<string, List<string>> _bookWatchlist = new();
    private readonly Dictionary<string, List<string>> _cdWatchlist = new();
    public event Action<string, string>? Notification;

    public void AddCustomerInterest(string customerName, InventoryType inventoryType, string title)
    {
        switch (inventoryType)
        {
            case InventoryType.Book:
            {
                if (!_bookWatchlist.ContainsKey(customerName))
                    _bookWatchlist[customerName] = [];

                _bookWatchlist[customerName].Add(title);
                break;
            }
            case InventoryType.Cd:
            {
                if (!_cdWatchlist.ContainsKey(customerName))
                    _cdWatchlist[customerName] = [];

                _cdWatchlist[customerName].Add(title);
                break;
            }
        }
    }

    public void AddNewItem(INewArrival newArrival)
    {
        var interestedCustomers = newArrival.Type == InventoryType.Book
            ? FindInterestedCustomers(_bookWatchlist, newArrival.Title)
            : FindInterestedCustomers(_cdWatchlist, newArrival.Title);


        interestedCustomers
            .ToList()
            .ForEach(c => FireNotificationEvent(c, newArrival.Title));
    }

    private void FireNotificationEvent(string customerName, string title)
    {
        Notification?.Invoke(customerName, title);
    }


    private IEnumerable<string> FindInterestedCustomers(Dictionary<string, List<string>> watchlist, string title)
    {
        return from pair in watchlist where pair.Value.Contains(title) select pair.Key;
    }
}