using MIAC.Domain.Core.Interfaces.DDD;
using MIAC.Patterns.Creational;
using System;

namespace MIAC.Domain.Core.Abstractions.DDD
{

    /// <summary>
    /// Представляет корень агрегации
    /// <para>Полезные ссылки:</para>
    /// <para>https://vaughnvernon.co/wordpress/wp-content/uploads/2014/10/DDD_COMMUNITY_ESSAY_AGGREGATES_PART_1.pdf</para>
    /// <para>https://vaughnvernon.co/wordpress/wp-content/uploads/2014/10/DDD_COMMUNITY_ESSAY_AGGREGATES_PART_2.pdf</para>
    /// <para>https://vaughnvernon.co/wordpress/wp-content/uploads/2014/10/DDD_COMMUNITY_ESSAY_AGGREGATES_PART_3.pdf</para>
    /// </summary>
    /// <typeparam name="T">Тип сущности, являющейся корнем агрегации</typeparam>
    /// <typeparam name="I">Тип локального идентификатора</typeparam>
    public abstract class AggregationRoot<T> : EntityBase,
        IAggregationRoot<T> where T : class, ICreator<T>
    {
        /// <summary>
        /// Глобальный идентификатор корня агрегации
        /// </summary>
        public virtual Guid GlobalId { get ; set ; }

        public abstract T Create();
    }

}
