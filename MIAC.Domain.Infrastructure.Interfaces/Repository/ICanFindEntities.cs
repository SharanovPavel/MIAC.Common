using MIAC.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MIAC.Domain.Infrastructure.Interfaces.Repository
{
    /// <summary>
    /// Предоставляет обобщенный интерфейс для поиска сущностей, имеющий локальный идентификатор, в хранилище
    /// </summary>
    /// <typeparam name="T">Тип элемента</typeparam>
    /// <typeparam name="I">Тип идентификатора элемента</typeparam>
    public interface ICanFindEntities<T, I> where T : IHasIdentityField<I>
    {
        /// <summary>
        /// Возвращает сущность по ее идентификатору
        /// </summary>
        /// <param name="id">Идентификатор сущности</param>
        /// <returns>Найденная сущность</returns>
        T Find(I id);

        /// <summary>
        /// Возвращает сущности по их идентификаторам
        /// </summary>
        /// <param name="ids">Идентификаторы</param>
        /// <returns>Найденные сущности</returns>
        IEnumerable<T> Find(IEnumerable<I> ids);
    }

    /// <summary>
    /// Представляет обобщенный интерфейс поиска сущностей с помощью лямбда - выражений (дерева выражений)
    /// </summary>
    public interface ICanFindEntitesByExpression<T> where T : class
    {
        /// <summary>
        /// Возвращает элементы, удовлетворяющие выражению <paramref name="expression"/>
        /// </summary>
        /// <param name="expression">Выражение для поиска в хранилище</param>
        /// <returns>Найденные сущности</returns>
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
    }

    /// <summary>
    /// Предоставляет интерфейс для поиска сущностей, имеющих глобальный идентификатор
    /// </summary>
    public interface ICanFindEntitesByGuid 
    {
        /// <summary>
        /// Возвращает из хранилища сущность с указанным GUID
        /// </summary>
        /// <param name="guid">Глобальный идентификатор</param>
        /// <returns></returns>
        T Find<T>(Guid guid) where T : IHasGlobalIdentity;

        /// <summary>
        /// Возвращает из хранилища все сущности, уникальные идентификаторы которых содержатся в <paramref name="guids"/>
        /// </summary>
        /// <param name="guids">Перечисление уникальных идентификаторов</param>
        /// <returns></returns>
        IEnumerable<T> Find<T>(IEnumerable<Guid> guids) where T : IHasGlobalIdentity;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICanFindEntitiesByGuid<T> where T : IHasGlobalIdentity
    {
        /// <summary>
        /// Возвращает из хранилища сущность с указанным GUID
        /// </summary>
        /// <param name="guid">Глобальный идентификатор</param>
        /// <returns></returns>
        T Find(Guid guid);

        /// <summary>
        /// Возвращает из хранилища все сущности, уникальные идентификаторы которых содержатся в <paramref name="guids"/>
        /// </summary>
        /// <param name="guids">Перечисление уникальных идентификаторов</param>
        /// <returns></returns>
        IEnumerable<T> Find(IEnumerable<Guid> guids);
    }
}
