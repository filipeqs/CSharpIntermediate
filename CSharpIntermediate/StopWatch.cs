using System;
namespace CSharpIntermediate
{
    public class StopWatch
    {
        private DateTime? StartTime { get; set; }
        public TimeSpan Duration { get; private set; }

        public void Start()
        {
            if (StartTime == null)
                StartTime = DateTime.Now;
            else
                throw new InvalidOperationException("Stopwatch already started");
        }

        public void Stop()
        {
            if (StartTime != null)
            {
                Duration = (TimeSpan)(DateTime.Now - StartTime);
                StartTime = null;
            }
            else
                throw new InvalidOperationException("Stopwatch already stoped");
        }
    }
}
