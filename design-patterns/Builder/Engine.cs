using design_patterns.Builder.contracts;

namespace design_patterns.Builder;

public class Engine(int horsepower) : IEngine
{
    public int Horsepower { get; } = horsepower;
}