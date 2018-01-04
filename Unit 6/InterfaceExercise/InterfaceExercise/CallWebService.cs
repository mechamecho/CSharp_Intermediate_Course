using System;

namespace InterfaceExercise
{
    public class CallWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Calling Web Service to notify that video is" +
                              "ready for encoding ...");
        }
    }
}