using System.Collections.Generic;

namespace InterfaceExercise
{
    class WorkflowEngine
    {
        
        public void Run(IWorkflow workflow)
        {

            foreach (var task in workflow.GetTasks())
            {
                task.Execute();
            }
        }


    }
}
