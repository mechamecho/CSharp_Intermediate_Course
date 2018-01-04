using System.Collections.Generic;

namespace InterfaceExercise
{
    public interface IWorkflow
    {
        void RegisterTask(ITask task);
        void RemoveTask(ITask task);
        IEnumerable<ITask> GetTasks();
    }
}
