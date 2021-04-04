namespace Digi21.Digi3D
{
    public abstract class TaskBase : ITask
    {
        protected string título;
        protected TaskSeverity severidad;
        protected string archivoDibujo;
        protected string módulo;
        protected ITask[] hijos;

        public TaskBase() => throw null;
        public TaskBase(string title, TaskSeverity severity) => throw null;
        public TaskBase(string title, TaskSeverity severity, string drawingFile, string module) => throw null;
        public TaskBase(string title, TaskSeverity severity, string drawingFile, string module, ITask[] childs) => throw null;
        public abstract void Execute();

        public ITask[] Childs { get => throw null; set => throw null; }
        public string Module { get => throw null; set => throw null; }
        public string DrawingFile { get => throw null; set => throw null; }
        public TaskSeverity Severity { get => throw null; set => throw null; }
        public string Title { get => throw null; set => throw null; }
    }
}
