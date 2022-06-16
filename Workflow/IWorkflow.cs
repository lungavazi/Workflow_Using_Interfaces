// See https://aka.ms/new-console-template for more information
public interface IWorkflow
{
    void AddWorkflow(IActivity activity);
    void RemoveWorkflow(IActivity activity);
    IEnumerable<IActivity> GetAllActivities();
    
}