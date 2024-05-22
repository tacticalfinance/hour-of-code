using design_patterns.AbstractFactory.contracts;

namespace design_patterns.AbstractFactory;

public class GuiFactory : IGuiFactory
{
    public IButton CreateButton(string theme)
    {
        if (theme == "Dark")
            return new DarkButton();

        if (theme == "Light")
            return new LightButton();

        throw new ArgumentException($"Can't create Button for theme {theme}");
    }

    public ITextBox CreateTextBox(string theme)
    {
        if (theme == "Dark")
            return new DarkTextBox();

        if (theme == "Light")
            return new LightTextBox();

        throw new ArgumentException($"Can't create TextBox for theme {theme}");
    }
}