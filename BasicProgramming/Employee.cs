using System.Security.AccessControl;
using System.Text.Encodings.Web;

namespace BasicProgramming;

public class Employee<TId>
{
    
    public TId Id { get; private set; }
    public string FullName { get; set; }
    public string Job { get; set; }
    private float salary;
    public float Salary {
        get => salary;
        set
        {
            if(value < 0)
            {
                Console.WriteLine("Salaray cant be less than 0");
                value = 0;
            }
            salary = value;
        }
    }
    public int Tes { get; init; }

    public Employee()
    {
        
    }  
    public Employee(TId Id)
    {
        this.Id = Id;
        System.Console.WriteLine("instantiate employee");
    }

    public Employee(TId Id, string FullName, string Job, float salary)
    {
        this.Id = Id;
        this.FullName = FullName;
        this.Job = Job;
        this.salary = salary;
        System.Console.WriteLine("instantiate employee");
    }

    public virtual void Introduction()
    {
        Console.WriteLine("=========");
        Console.WriteLine("ID : " + Id);
        Console.WriteLine("NAME : " + FullName);
        Console.WriteLine("SALARY : " + salary);
        Console.WriteLine("JOB : " + Job);
    }

    public float CalculateTax()
    {
        float tax = 2.5f;
        return salary * tax;
    }

    public float CalculateTax(float additionalFee)
    {
        float tax = 2.5f;
        return salary * tax + salary * additionalFee;
    }

    public virtual float CalculateTax(int additionalFees)
    {
        float tax = 2.5f;
        return salary * tax + salary * additionalFees;
    }
}
