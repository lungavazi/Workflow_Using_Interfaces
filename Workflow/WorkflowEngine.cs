 public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
        foreach (var activity in workflow.GetAllActivities())
        {
            try
            {
                activity.Execute();
            }
            catch (Exception)
            {
                throw;
            }
        }
        }

    }
