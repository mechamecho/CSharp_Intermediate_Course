using System;

namespace InterfaceExercise
{
    public class UploadVideo :ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video to cloud storage ...");
        }
    }
}
