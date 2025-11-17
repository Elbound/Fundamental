namespace VendingMachineApp;

public class Candy : Item
{
    public Candy(string name, decimal price, int quantity) : base(name, price, quantity)
    {
    }

    public override void Dispense()
    {
        System.Console.WriteLine("*Thud*... (Sweet!)");
    }
}