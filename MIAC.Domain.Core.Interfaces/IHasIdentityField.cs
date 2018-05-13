namespace MIAC.Domain.Core.Interfaces
{
    /// <summary>
    /// Предоставляет интерфейс для однозначной идентификации элемента с помощью идентификатора типа <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T">Тип идентификатора элемента</typeparam>
    public interface IHasIdentityField<T>
    {
        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        T Id { get; set; }
    }

}
