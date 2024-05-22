using design_patterns.AbstractFactory;
using design_patterns.AbstractFactory.contracts;
using design_patterns.tests.mock;
using Xunit;

namespace design_patterns.tests;

public class AbstractFactoryTests
{
    [Fact]
    public void TestLightTheme()
    {
        IGuiFactory factory = new LightThemeFactory();
        IButton button = factory.CreateButton();
        ITextBox textBox = factory.CreateTextBox();

        Assert.IsType<LightButton>(button);
        Assert.IsType<LightTextBox>(textBox);

        using var console = new ConsoleMock();
        button.Render();
        textBox.Render();
        Assert.Equal($"Light Button{Environment.NewLine}Light TextBox{Environment.NewLine}", console.Output);
    }

    [Fact]
    public void TestDarkTheme()
    {
        IGuiFactory factory = new DarkThemeFactory();
        IButton button = factory.CreateButton();
        ITextBox textBox = factory.CreateTextBox();

        Assert.IsType<DarkButton>(button);
        Assert.IsType<DarkTextBox>(textBox);

        using var console = new ConsoleMock();
        button.Render();
        textBox.Render();
        Assert.Equal($"Dark Button{Environment.NewLine}Dark TextBox{Environment.NewLine}", console.Output);
    }
}