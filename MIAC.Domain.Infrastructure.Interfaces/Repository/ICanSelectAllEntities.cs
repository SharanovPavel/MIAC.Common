using System.Collections.Generic;

namespace MIAC.Domain.Infrastructure.Interfaces.Repository
{
    /// <summary>
    /// Предоставляет обобщенный интерфейс для загрузки всех сущностей из хранилища
    /// </summary>
    /// <typeparam name="T">Тип сущности</typeparam>
    public interface ICanSelectAllEntities<T> where T : class
    {
        /// <summary>
        /// Возвращает все сущности, находящиеся в хранилище
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> SelectAll();
    }

    /// <summary>
    /// Предоставляет обобщенный метод полной выгрузки типизированного набора элементов из хранилища
    /// </summary>
    public interface ICanSelectAllEntities
    {
        /// <summary>
        /// Полностью выгружает типизированный набор элементов из хранилища
        /// </summary>
        /// <typeparam name="T">Тип элемента</typeparam>
        /// <returns></returns>
        IEnumerable<T> SelectAll<T>() where T : class;
    }
}
