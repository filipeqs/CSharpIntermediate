namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Activities.Add(new SendEmail());
            workflow.Activities.Add(new CloudStorage());
            workflow.Activities.Add(new VideoRecording());

            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}
