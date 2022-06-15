// See https://aka.ms/new-console-template for more information
public class CreateOrder : IActivity
{
    public void Execute()
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("Processing Order...");
        Console.WriteLine("Sending email to the customer...");
    }
}