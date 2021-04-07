namespace Digi21.Tasks
{
    public interface ITask
    {
        void Execute();
        ITask[] Childs { get; }
        string Module { get; }
        string DrawingFile { get; }
        TaskSeverity Severity { get; }
        string Title { get; }
    }
}
