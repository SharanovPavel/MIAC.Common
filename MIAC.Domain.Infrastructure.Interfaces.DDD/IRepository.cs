using MIAC.Domain.Core.Abstractions.DDD;
using MIAC.Domain.Infrastructure.Interfaces.Repository;

namespace MIAC.Domain.Core.Interfaces.DDD
{
    /// <summary>
    /// Предоставляет интерфейс хранилища в концепции Domain Driven Disign
    /// </summary>
    /// <typeparam name="T">Тип агрегата</typeparam>
    public interface IRepository<T> :
        ICanFindEntitiesByGuid<T>,
        ICanFindEntitesByExpression<T>,
        ICanSelectAllEntities<T>,
        ICanInsertEntities<T>,
        ICanRemoveEntitiesByGuid<T>,
        ICanUpdateEntities<T> where T : AggregationRoot<T>
    {
    }

    

}
