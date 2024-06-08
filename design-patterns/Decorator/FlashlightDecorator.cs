using design_patterns.Decorator.contracts;

namespace design_patterns.Decorator;

public class FlashlightDecorator(IRifle decorated) : AbstractRifleDecorator(decorated)
{
    public override string Description => $"{Decorated.Description} + Flashlight";
    public override double Price => Decorated.Price + 100;
}