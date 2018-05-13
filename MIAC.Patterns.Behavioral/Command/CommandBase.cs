namespace MIAC.Patterns.Behavioral.Command
{
    /// <summary>
    /// Представляет абстрактную реализацию <see cref="ICommand"/> с типом получателя <typeparamref name="ReceiverT"/>
    /// </summary>
    /// <typeparam name="ReceiverT"></typeparam>
    public abstract class CommandBase<ReceiverT> : ICommand where ReceiverT : class
    {
        protected ReceiverT Reсeiver { get; set; }

        public CommandBase(ReceiverT receiver)
        {
            Reсeiver = receiver;
        }

        public abstract void Execute();
    }

    public class NullCommand<T>:CommandBase<T> where T : class
    {
        public NullCommand() : base(null) { }

        public override void Execute() { }
    }
}
