namespace Digi21.Tasks
{
    public interface ITask
    {
        void Execute();
        ITask[] Children { get; }
        string Module { get; }
        string DrawingFile { get; }
        TaskSeverity Severity { get; }
        string Title { get; }
    }
}
