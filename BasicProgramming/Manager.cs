namespace BasicProgramming;

public class Manager: Employee
{
    public Manager(int Id) : base(Id)
    {
        System.Console.WriteLine("instantiate manager");
    }

    public int Allowance { get; set; }

    public override void Introduction()
    {
        base.Introduction();
        System.Console.WriteLine("Allowance: " + Allowance);
    }

    public override float CalculateTax(int additionalFees)
    {
        return base.CalculateTax(additionalFees) + Allowance;
    }

    
}
