using design_patterns.Decorator.contracts;

namespace design_patterns.Decorator;

public class BipodsDecorator(IRifle decorated) : AbstractRifleDecorator(decorated)
{
    public override string Description => $"{Decorated.Description} + Bipods";
    public override double Price => Decorated.Price + 120;
}