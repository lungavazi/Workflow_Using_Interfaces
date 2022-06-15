// See https://aka.ms/new-console-template for more information
public class OrderWorkflow
{
    private readonly IList<IActivity> _activities = new List<IActivity>();

    public OrderWorkflow()
    {
        _activities = new List<IActivity>();
    }     

    public void Run()
    {
        foreach (var item in _activities)
        {
            item.Execute();
        }
    }

    public void AddOrderWorkflow(IActivity activity)
    {
       _activities.Add(activity);
    }
}
