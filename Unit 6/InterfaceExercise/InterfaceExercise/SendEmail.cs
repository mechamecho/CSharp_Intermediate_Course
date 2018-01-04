using System;

namespace InterfaceExercise
{
    public class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Emailing video owner that video started processing ...");
        }
    }
}
