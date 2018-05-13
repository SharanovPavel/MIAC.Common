namespace MIAC.Patterns.Behavioral.Command
{
    /// <summary>
    /// Предоставляет интерфейс выполнения команды (паттерн "Command" (Команда))
    /// <para>Используйте <see cref="IUndoableCommand"/> и <see cref="IRedoableCommand"/> для расширения функционала реализаций</para>
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Выполняет текущую команду
        /// </summary>
        void Execute();
    }

    /// <summary>
    /// Предоставляет расширение интерфейса <see cref="ICommand"/> с возможностью отката выполнения команды
    /// </summary>
    public interface IUndoableCommand : ICommand
    {
        /// <summary>
        /// Откатывает изменения
        /// </summary>
        void Undo();
    }

    /// <summary>
    /// Предоставляет расширение интерфейса <see cref="ICommand"/> с возможностью повтора выполнения команды
    /// </summary>
    public interface IRedoableCommand : ICommand
    {
        /// <summary>
        /// Повторяет выполнение комманды
        /// </summary>
        void Redo();
    }
}
