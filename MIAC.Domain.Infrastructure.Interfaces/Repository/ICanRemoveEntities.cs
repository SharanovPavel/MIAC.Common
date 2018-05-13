using MIAC.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace MIAC.Domain.Infrastructure.Interfaces.Repository
{
    /// <summary>
    /// Предоставляет интерфейс исключения сущностей из хранилища
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="I"></typeparam>
    public interface ICanRemoveEntities<T> where T : class
    {
        /// <summary>
        /// Исключает сущность из хранилища
        /// </summary>
        /// <param name="item"></param>
        void Remove(T item);

        /// <summary>
        /// Исключает сущности из хранилища
        /// </summary>
        /// <param name="items">Корни агрегации</param>
        void Remove(IEnumerable<T> items);
    }

    /// <summary>
    /// Определяет интерфейс исключения сущностей из хранилища по идентификатору
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="I"></typeparam>
    public interface ICanRemoveEntitiesById<T, I> where T : IHasIdentityField<I>
    {
        /// <summary>
        /// Исключает из хранилища сущность по идентификатору
        /// </summary>
        /// <param name="id"></param>
        void Remove(I id);

        /// <summary>
        /// Исключает сущности из хранилища по идентификаторам
        /// </summary>
        /// <param name="ids">Идентификаторы</param>
        void Remove(IEnumerable<I> ids);
    }

    /// <summary>
    /// Предоставляет интерфейс для удаления сущности из хранилища по глобальному идентификатору
    /// </summary>
    public interface ICanRemoveEntitiesByGuid
    {
        /// <summary>
        /// Исключает из хранилища сущность по глобальному идентификатору
        /// </summary>
        /// <param name="id">Глобальный идентификатор</param>
        void Remove(Guid id);

        /// <summary>
        /// Исключает сущности из хранилища по идентификаторам
        /// </summary>
        /// <param name="ids">Глобальные идентификаторы</param>
        void Remove(IEnumerable<Guid> ids);
    }

    /// <summary>
    /// Предоставляет интерфейс для удаления сущности из хранилища по глобальному идентификатору
    /// </summary>
    public interface ICanRemoveEntitiesByGuid<T>
    {
        /// <summary>
        /// Исключает из хранилища сущность по глобальному идентификатору
        /// </summary>
        /// <param name="id">Глобальный идентификатор</param>
        void Remove(Guid id);

        /// <summary>
        /// Исключает сущности из хранилища по идентификаторам
        /// </summary>
        /// <param name="ids">Глобальные идентификаторы</param>
        void Remove(IEnumerable<Guid> ids);
    }
}
