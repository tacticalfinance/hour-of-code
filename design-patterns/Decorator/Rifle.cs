using design_patterns.Decorator.contracts;

namespace design_patterns.Decorator;

public class Rifle : IRifle
{
    public virtual string Description => "Rifle";
    public virtual double Price => 500.0;
}