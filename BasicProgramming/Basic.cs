namespace BasicProgramming;
public enum Status {completed, failed}
public class Basic
{
    static string FullName(string firstName, string lastName)
    {
        return firstName +" "+lastName;
    }
    
    static int Age()
    {
        return 20;
    }

    static void notMain()
    {
        int age = 20;
        string name = "Theo";
        // age += 14;
        string last = "";

        Console.WriteLine("Name: "+ FullName("Theo", "Stanza"));
        Console.WriteLine("Age: "+ Age());

        if (age > 30)
        {
            Console.WriteLine("Expired");
        }
        else if(age > 18)
        {
            Console.WriteLine("Yo");
        }
        else
        {
            Console.WriteLine("yo");
        }

        var nim = 10;

        var stat = Status.failed;
        
        switch (stat)
        {
            case Status.completed:
                Console.WriteLine(stat);
                break;
            case Status.failed:
                Console.WriteLine(stat);
                break;
            default:
                break;

        }

        for(int i=1; i<=10; i++)
        {
            if(i%2 == 1)
            {
              Console.WriteLine(i);  
            }
            
        }

    }
    
}