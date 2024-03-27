using design_patterns.Observer.contracts;

namespace design_patterns.Observer;

public class NewArrival(string title, InventoryType inventoryType) : INewArrival
{
    public string Title => title;
    public InventoryType Type => inventoryType;
}