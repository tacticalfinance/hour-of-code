namespace design_patterns.Strategy;

public class CyclingStrategy : AbstractStrategy
{
    protected override NavigationType NavigationType => NavigationType.Cycling;
    protected override int Divider => 4;
}