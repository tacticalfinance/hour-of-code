namespace design_patterns.Strategy;

public class DrivingStrategy : AbstractStrategy
{
    protected override NavigationType NavigationType => NavigationType.Driving;
    protected override int Divider => 2;
}