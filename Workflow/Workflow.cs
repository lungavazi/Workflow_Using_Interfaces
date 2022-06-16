// See https://aka.ms/new-console-template for more information
public class Workflow : IWorkflow
{
    private readonly IList<IActivity> _activities = new List<IActivity>();

    public Workflow()
    {
        _activities = new List<IActivity>();
    } 

    public void AddWorkflow(IActivity activity)
    {
        _activities.Add(activity);
    }

    public void RemoveWorkflow(IActivity activity)
    {
        if (_activities.Contains(activity))
        {
            _activities.Remove(activity);
        }
    }

    public IEnumerable<IActivity> GetAllActivities()
    {
        return _activities;
    }
}
