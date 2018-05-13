using System.Collections.Generic;

namespace MIAC.Domain.Infrastructure.Interfaces.Repository
{
    /// <summary>
    /// Предоставляет интерфейс для обновления состояния корня агрегации типа <typeparamref name="T"/> в хранилище
    /// </summary>
    /// <typeparam name="T">Тип сущности</typeparam>
    public interface ICanUpdateEntities<T> where T : class
    {
        /// <summary>
        /// Обновляет состояние корня агрегации в хранилище
        /// </summary>
        /// <param name="item">Существующий корень агрегации</param>
        void Update(T item);

        /// <summary>
        /// Обновляет состояние корней агрегации в хранилище
        /// </summary>
        /// <param name="items"></param>
        void Update(IEnumerable<T> items);
    }
}
