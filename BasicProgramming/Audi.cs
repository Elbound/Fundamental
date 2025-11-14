namespace BasicProgramming;

public class Audi : Car, IMachine
{
    public void Break()
    {
        System.Console.WriteLine("Sliding");
    }

    public void Move()
    {
        System.Console.WriteLine("kedepan");
    }


    public override void OpenDoor()
    {
        System.Console.WriteLine("muter");
    }

    public override void OpenWindow()
    {
        System.Console.WriteLine("open aja lah");;
    }

}
