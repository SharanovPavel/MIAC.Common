namespace MIAC.Patterns.Creational
{
    /// <summary>
    /// Определяет базовый интерфейс паттерна "Строитель" (Builder) для типа <see cref="T"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBuilder<T> : ICanCreateObject<T> where T : class
    {
        /// <summary>
        /// Сбрасывает состояние экземпляра
        /// </summary>
        void Reset();
    }
}
