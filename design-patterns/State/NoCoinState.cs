namespace design_patterns.State;

public class NoCoinState(ICandyVendingMachine machine) : ICandyVendingMachineState
{
    public void InsertCoin()
    {
        machine.SetState(new ContainsCoinState(machine));
        machine.Message = "Ready";
    }

    public void PressButton()
    {
        machine.Message = "Please insert a coin";
    }
}