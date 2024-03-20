using design_patterns.Builder.contracts;

namespace design_patterns.Builder;

public class Body(string shape) : IBody
{
    public string Shape { get; } = shape;
}