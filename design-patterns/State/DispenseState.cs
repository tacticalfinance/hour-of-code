namespace design_patterns.State;

public class DispenseState(ICandyVendingMachine machine) : ICandyVendingMachineState
{
    public void InsertCoin()
    {
        throw new NotImplementedException();
    }

    public void PressButton()
    {
        throw new NotImplementedException();
    }
}