// See https://aka.ms/new-console-template for more information
public class ProcessOrder : IActivity
{
    public void Execute()
    {
        Console.BackgroundColor = ConsoleColor.Magenta;   
        Console.WriteLine("Preparing your order, this might take up to 10 minutes...");
        Thread.Sleep(10000);
    }
}
