using design_patterns.Observer.contracts;

namespace design_patterns.Observer;

public class StoreSubject : IStoreSubject
{
    private readonly List<IObserver> _observers = [];
    private INewArrival? _newArrival;

    public INewArrival? NewArrival
    {
        get => _newArrival;
        set
        {
            _newArrival = value;
            Notify();
        }
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    private void Notify()
    {
        _observers.ForEach(o => o.Update(this));
    }
}