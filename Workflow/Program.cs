// See https://aka.ms/new-console-template for more information


var OrderWorkflow = new OrderWorkflow();
OrderWorkflow.AddOrderWorkflow(new CreateOrder());
OrderWorkflow.AddOrderWorkflow(new ProcessOrder());
OrderWorkflow.AddOrderWorkflow(new CompletingOrder());
OrderWorkflow.Run();