using System;
using System.Collections.Generic;

namespace MIAC.Domain.Infrastructure.Interfaces.Repository
{
    /// <summary>
    /// Предоставляет обобщенный интерфейс для добавления сущности в хранилище
    /// </summary>
    /// <typeparam name="T">Тип сущности</typeparam>
    public interface ICanInsertEntities<T> where T : class
    {
        /// <summary>
        /// Добавляет корень агрегации в хранилище
        /// </summary>
        /// <param name="item">Новый корень агрегации</param>
        /// <exception cref="ArgumentNullException"></exception>
        void Insert(T item);

        /// <summary>
        /// Добавляет 
        /// </summary>
        /// <param name="items">Новые корни агрегации</param>
        /// <exception cref="ArgumentNullException"></exception>
        void Insert(IEnumerable<T> items);
    }
}
