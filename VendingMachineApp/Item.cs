namespace VendingMachineApp;

public abstract class Item
{
    public string Name { get; protected set; }
    public decimal Price { get; protected set; }
    public int Quantity { get; set; }

    protected Item(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public abstract void Dispense();
}