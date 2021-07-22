using System;

namespace WorkflowEngine
{
    public class VideoRecording : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video Recording");
        }
    }
}
