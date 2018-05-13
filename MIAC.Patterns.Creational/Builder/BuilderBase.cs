namespace MIAC.Patterns.Creational
{
    /// <summary>
    /// Представляет абстрактный строитель объектов типа <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BuilderBase<T>:IBuilder<T> where T : class, new()
    {
        /// <summary>
        /// Экземпляр типа <see cref="T"/>
        /// </summary>
        protected virtual T Object { get; set; }

        public BuilderBase()
        {
            Object = new T();
        }

        /// <summary>
        /// Возвращает текущее состояние экземпляра
        /// </summary>
        public virtual T Create()
        {
            return Object ?? new T();
        }

        /// <summary>
        /// Сбрасывает текущее состояние
        /// </summary>
        public virtual void Reset()
        {
            Object = new T();
        }
    }
}
