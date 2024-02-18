namespace design_patterns.Strategy;

public class FlyingStrategy : AbstractStrategy
{
    protected override NavigationType NavigationType => NavigationType.Flying;
    protected override int Divider => 1;
}