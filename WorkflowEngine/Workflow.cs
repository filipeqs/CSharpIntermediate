using System.Collections.Generic;

namespace WorkflowEngine
{
    public class Workflow
    {
        public List<IActivity> Activities { get; private set; }

        public Workflow()
        {
            Activities = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            Activities.Add(activity);
        }
    }
}
