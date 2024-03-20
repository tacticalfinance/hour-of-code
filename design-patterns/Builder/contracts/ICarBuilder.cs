namespace design_patterns.Builder.contracts;

public interface ICarBuilder
{
    ICar Car { get; }
    void BuildBody();
    void BuildEngine();
    void BuildWheel();
}