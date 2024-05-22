using design_patterns.AbstractFactory.contracts;

namespace design_patterns.AbstractFactory;

public class LightButton : IButton
{
    public void Render() => Console.WriteLine("Light Button");
}