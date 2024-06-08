using design_patterns.Decorator.contracts;

namespace design_patterns.Decorator;

public abstract class AbstractRifleDecorator(IRifle decorated) : IRifle
{
    public IRifle Decorated { get; } = decorated;
    public abstract string Description { get; }
    public abstract double Price { get; }
}