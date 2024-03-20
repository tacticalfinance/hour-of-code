using design_patterns.Builder.contracts;

namespace design_patterns.Builder;

public abstract class AbstractCarBuilder : ICarBuilder
{
    public ICar Car { get; protected set; } = null!;

    public void StartNewCar()
    {
        Car = new Car();
    }

    public abstract void BuildBody();
    public abstract void BuildEngine();
    public abstract void BuildWheel();
}