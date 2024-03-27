namespace design_patterns.Observer.contracts;

public interface INewArrival
{
    string Title { get; }
    InventoryType Type { get; }
}