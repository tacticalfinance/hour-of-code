namespace design_patterns.Observer.contracts;

public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
}