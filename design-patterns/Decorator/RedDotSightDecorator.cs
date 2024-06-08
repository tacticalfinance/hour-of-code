using design_patterns.Decorator.contracts;

namespace design_patterns.Decorator;

public class RedDotSightDecorator(IRifle decorated) : AbstractRifleDecorator(decorated)
{
    public override string Description => $"{Decorated.Description} + Red Dot Sight";
    public override double Price => Decorated.Price + 100;
}