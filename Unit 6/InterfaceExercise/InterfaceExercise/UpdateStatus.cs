using System;

namespace InterfaceExercise
{
    class UpdateStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Updating video status to processing in Database...");
        }
    }
}
