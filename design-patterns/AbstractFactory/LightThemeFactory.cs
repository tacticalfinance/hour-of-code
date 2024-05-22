using design_patterns.AbstractFactory.contracts;

namespace design_patterns.AbstractFactory;

public class LightThemeFactory : IGuiFactory
{
    public IButton CreateButton() => new LightButton();
    public ITextBox CreateTextBox() => new LightTextBox();
}