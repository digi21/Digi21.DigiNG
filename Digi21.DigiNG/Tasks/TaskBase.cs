namespace Digi21.Tasks
{
    public abstract class TaskBase : ITask
    {
        private string título;
        private TaskSeverity severidad;
        private string archivoDibujo;
        private string módulo;
        private ITask[] hijos;

        protected TaskBase() => throw null;
        protected TaskBase(string title, TaskSeverity severity) => throw null;
        protected TaskBase(string title, TaskSeverity severity, string drawingFile, string module) => throw null;
        protected TaskBase(string title, TaskSeverity severity, string drawingFile, string module, ITask[] childs) => throw null;
        public abstract void Execute();

        public ITask[] Childs { get => throw null; set => throw null; }
        public string Module { get => throw null; set => throw null; }
        public string DrawingFile { get => throw null; set => throw null; }
        public TaskSeverity Severity { get => throw null; set => throw null; }
        public string Title { get => throw null; set => throw null; }
    }
}
