namespace design_patterns.Decorator;

public class RifleWithFlashlight : Rifle
{
    public override string Description => $"{base.Description} + Flashlight";
    public override double Price => base.Price + 100.0;
}