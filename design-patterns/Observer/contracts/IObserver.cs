namespace design_patterns.Observer.contracts;

public interface IObserver
{
    void Update(ISubject subject);
}