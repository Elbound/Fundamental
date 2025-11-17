using System.Security.Cryptography;

namespace BasicProgramming;

class Program
{

    static void Main(string[] args)
    {
        
        Employee<int> ahmad = new Employee<int>(1001);
        var imam = new Employee<int>(1002);

        ahmad.FullName = "Ahmad Izzudin";
        // ahmad.Id = 901306;
        ahmad.Job = "Selebgram";
        ahmad.Salary = -10.0f; //redenomisasi

        imam.FullName = "Imam Izzudin";
        // imam.Id = 901306;
        imam.Job = "Tiktokers";
        imam.Salary = 5.500f;

        imam.Introduction();
        ahmad.Introduction();

        Console.WriteLine(ahmad.Tes);

        // Console.WriteLine($"lalala {imam.salary}");

         var joko = new Manager<string>("M01");
        joko.FullName = "Joko Izzudin";
        joko.Salary = 10.0f;
        joko.Job = "Technical Consultant Manager";
        joko.Allowance = 5;
        joko.Introduction();
        System.Console.WriteLine(joko.Allowance);

        System.Console.WriteLine("========mobil===========");
        var a8 = new Audi();
        a8.IsManual =true;
        a8.MaxGear = 6;
        a8.TopSpeed = 250;
        a8.OpenDoor();
        a8.OpenWindow();

        System.Console.WriteLine("========mobil===========");
        var rs6 = new Audi();
        rs6.IsManual = true;
        rs6.MaxGear = 8;
        rs6.TopSpeed = 200;

        rs6.Move();
        rs6.Break();
        rs6.StartEngine();

        System.Console.WriteLine("========mobil===========");
        var ag = new Mercedes();
        ag.MaxGear = 7;
        ag.TopSpeed = 200;
        ag.IsManual = false;

        IMachine agy = new Mercedes();
        System.Console.WriteLine("Agy");
        agy.Break();

        System.Console.WriteLine("==========end==========");

        List<int> numbers = new List<int>() {1,2,3};
        numbers.Add(4);
        numbers.Add(5);
        numbers.Add(6);

        numbers.RemoveAt(5);

        foreach (var a in numbers)
        {
            System.Console.WriteLine(a);
        }

        List<Employee<int>> employees = new List<Employee<int>>();

        employees.Add(new Employee<int>(111, "Jhon Doe", "SE", 3f));
        employees.Add(new Employee<int>(
            114, 
            "Lmda", 
            "Officer",
            4f
        ));

        employees.Add(new Employee<int>(99)
        {
           FullName = "lala",
           Job = "lomba",
           Salary = 30f 
        });



        foreach(var i in employees)
        {
            i.Introduction();
        }

        // IReadOnlyList<Employee<int>> employeesRead = new IReadOnlyList<Employee<int>>();
    }

}