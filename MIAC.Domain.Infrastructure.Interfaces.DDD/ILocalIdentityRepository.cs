using MIAC.Domain.Core.Abstractions.DDD;
using MIAC.Domain.Infrastructure.Interfaces.Repository;

namespace MIAC.Domain.Core.Interfaces.DDD
{
    /// <summary>
    /// Предоставляет интерфейс хранилища элементов с локальным идентификатором в концепции Domain Driven Disign
    /// </summary>
    /// <typeparam name="T">Тип агрегата</typeparam>
    /// <typeparam name="I">Тип локального идентификатора агрегата</typeparam>
    public interface ILocalIdentityRepository<T, I> : 
        ICanFindEntities<T, I>,
        ICanFindEntitiesByGuid<T>,
        ICanFindEntitesByExpression<T>,
        ICanSelectAllEntities<T>,
        ICanInsertEntities<T>,
        ICanRemoveEntities<T>,
        ICanRemoveEntitiesByGuid<T>,
        ICanUpdateEntities<T> where T : IdentifiableAggregationRoot<T, I>
    {

    }
}
