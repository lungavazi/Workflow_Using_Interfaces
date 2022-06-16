// See https://aka.ms/new-console-template for more information


var OrderWorkflow = new Workflow();
OrderWorkflow.AddWorkflow(new CreateOrder());
OrderWorkflow.AddWorkflow(new ProcessOrder());
OrderWorkflow.AddWorkflow(new CompletingOrder());

var WorkflowEngine = new WorkflowEngine();
WorkflowEngine.Run(OrderWorkflow);  