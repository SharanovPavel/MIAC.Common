using MIAC.Domain.Core.Interfaces;
using MIAC.Patterns.Creational;

namespace MIAC.Domain.Core.Abstractions.DDD
{
    public abstract class IdentifiableAggregationRoot<T, I> : AggregationRoot<T>, IHasIdentityField<I> where T : class, ICreator<T>
    {
        public virtual I Id { get; set; }
    }
}
