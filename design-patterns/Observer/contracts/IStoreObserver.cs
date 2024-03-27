namespace design_patterns.Observer.contracts;

public interface IStoreObserver : IObserver
{
    INewArrival? NewArrival { get; }
}