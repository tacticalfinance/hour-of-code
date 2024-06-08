namespace design_patterns.Decorator;

public class RifleWithRedDotSight : Rifle
{
    public override string Description => $"{base.Description} + Red Dot Sight";
    public override double Price => base.Price + 100.0;
}