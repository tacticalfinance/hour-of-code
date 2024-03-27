namespace design_patterns.Observer.contracts;

public interface IStoreSubject : ISubject
{
    INewArrival? NewArrival { get; set; }
}