using design_patterns.AbstractFactory.contracts;

namespace design_patterns.AbstractFactory;

public class DarkTextBox : ITextBox
{
    public void Render() => Console.WriteLine("Dark TextBox");
}