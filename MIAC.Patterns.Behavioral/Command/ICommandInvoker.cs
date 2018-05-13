namespace MIAC.Patterns.Behavioral.Command
{
    public interface ICommandInvoker
    {
        void SetCommand(ICommand command);
        void Run();
        void Cancel();
    }
}
