namespace design_patterns.Decorator;

public class TestRifleWithRedDotSightAndBipods : RifleWithRedDotSight
{
    public override string Description => $"{base.Description} + Bipods";
    public override double Price => base.Price + 120.0;
}