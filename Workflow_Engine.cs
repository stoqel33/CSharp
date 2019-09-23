using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow_engine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowengine = new WorkflowEngine();
            var videoEncodingworklflow = new VideoEncodingWorkflow();
            workflowengine.Run(videoEncodingworklflow);
        }
    }

    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            if (workflow.Activities.Count == 0 || workflow == null)
                throw new ArgumentException(nameof(workflow), "Workflow activity list is empty or null.");
            foreach (var activity in workflow.Activities)
            {
                activity.Execute();
            }
        }
    }

    public interface IActivity
    {
        void Execute();
    }

    public abstract class Workflow
    {
        public IList<IActivity> Activities { get; set; } = new List<IActivity>();
    }

    public class UploadVideoActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading Video...");
        }
    }

    public class UpdateDatabaseActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Updating database...");
        }
    }
    public class StartEncodingActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Encoding now...");
        }
    }
    public class SendEmailActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending email...");
        }
    }
    class VideoEncodingWorkflow : Workflow
    {
        public VideoEncodingWorkflow()
            : base()
        {
            Activities.Add(new SendEmailActivity());
            Activities.Add(new StartEncodingActivity());
            Activities.Add(new UploadVideoActivity());
            Activities.Add(new UpdateDatabaseActivity());
        }
    }
}
