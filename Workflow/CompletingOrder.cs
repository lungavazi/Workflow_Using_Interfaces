// See https://aka.ms/new-console-template for more information
public class CompletingOrder : IActivity
{
    public void Execute()
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("Order is ready for collection, sending email to the customer...");
        Console.WriteLine("Email received...");        
    }
}