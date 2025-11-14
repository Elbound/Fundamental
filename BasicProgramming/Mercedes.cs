namespace BasicProgramming;

public class Mercedes : Car, IMachine
{
    public void Break()
    {
       System.Console.WriteLine("Ankor");
    }

    public void Move()
    {
        System.Console.WriteLine("Horse power");
    }


    public override void OpenDoor()
    {
        System.Console.WriteLine("Detatchable");
    }

    public override void OpenWindow()
    {
        System.Console.WriteLine("Slide Sideways");
    }

}
