namespace design_patterns.Decorator;

public class RifleWithBipods : Rifle
{
    public override string Description => $"{base.Description} + Bipods";
    public override double Price => base.Price + 120.0;
}