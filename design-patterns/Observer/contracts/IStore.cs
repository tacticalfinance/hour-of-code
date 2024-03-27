namespace design_patterns.Observer.contracts;

public interface IStore
{
    void AddCustomerInterest(string customerName, InventoryType inventoryType, string title);
    void AddNewItem(INewArrival newArrival);
    event Action<string, string> Notification;
}