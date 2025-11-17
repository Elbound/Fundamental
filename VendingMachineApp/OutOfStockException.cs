namespace VendingMachineApp;

class OutOfStockException : Exception
{
    public OutOfStockException(string message): base(message)
    {
       
    }
}