using MIAC.Patterns.Creational;

namespace MIAC.Domain.Core.Interfaces.DDD
{
    public interface IAggregationRoot<T> : IHasGlobalIdentity, ICreator<T> where T : class, ICreator<T>
    {
    }
}
