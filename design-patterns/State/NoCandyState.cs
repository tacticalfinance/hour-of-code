namespace design_patterns.State;

public class NoCandyState(ICandyVendingMachine machine) : ICandyVendingMachineState
{
    public void InsertCoin()
    {
        machine.Message = "No candies available";
    }

    public void PressButton()
    {
        machine.Message = "No candies available";
    }
}