namespace MIAC.Patterns.Creational
{
    /// <summary>
    /// Обобщенный интерфейс для большинства порождающих паттернов
    /// </summary>
    /// <typeparam name="T">Тип порождаемой сущности</typeparam>
    public interface ICanCreateObject<T> where T : class
    {
        /// <summary>
        /// Создает экземпляр объекта
        /// </summary>
        /// <returns></returns>
        T Create();
    }
}
