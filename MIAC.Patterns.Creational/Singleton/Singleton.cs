namespace MIAC.Patterns.Creational
{
    /// <summary>
    /// Представляет базовую реализацию паттерна "Одиночка" (Singleton)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Singleton<T> where T : class, new()
    {
        /// <summary>
        /// Экземпляр сущности
        /// </summary>
        protected static T Instance { get; set; }

        /// <summary>
        /// Получить объект-одиночку
        /// </summary>
        /// <returns>Экземпляр объекта-одиночки</returns>
        public static T Create()
        {
            if (Instance == null)
                Instance = new T();
            return Instance;
        }
    }
}
