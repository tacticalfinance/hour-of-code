namespace design_patterns.Builder.contracts;

public interface ICarBuilder
{
    ICar Car { get; }
    void StartNewCar();
    void BuildBody();
    void BuildEngine();
    void BuildWheel();
}