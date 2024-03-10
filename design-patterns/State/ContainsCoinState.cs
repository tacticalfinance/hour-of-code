using System.Reflection.PortableExecutable;

namespace design_patterns.State;

public class ContainsCoinState(ICandyVendingMachine machine) : ICandyVendingMachineState
{
    public void InsertCoin()
    {
        machine.Message = "Coin already inserted";
    }

    public void PressButton()
    {
        machine.SetState(new DispenseState(machine));
        machine.Message ="Dispensing";
        machine.Dispense();
    }
}