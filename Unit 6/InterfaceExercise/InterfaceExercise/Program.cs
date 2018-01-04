using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow= new Workflow();
            workflow.RegisterTask(new UploadVideo());
            workflow.RegisterTask(new CallWebService());
            workflow.RegisterTask(new SendEmail());
            workflow.RegisterTask(new UpdateStatus());

            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);

        }
    }
}
