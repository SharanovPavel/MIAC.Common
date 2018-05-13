using MIAC.Domain.Core.Interfaces;
using System;

namespace MIAC.Domain.Core.Abstractions
{
    /// <summary>
    /// Представляет сущность доменной модели, имеющую идентификатор типа <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T">Тип идентификатора</typeparam>
    public abstract class IdentifiableEntity<T> : EntityBase, IHasIdentityField<T>
    {
        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        public virtual T Id { get; set; }

        /// <summary>
        /// Является ли объект временным (т.е. у него нет своего ID, а значит его состояние не сохранено в хранилище)
        /// </summary>
        public bool IsTransient => this.Id.Equals(default(T));

        /// <summary>
        /// ВЫполняет проверку равенства двух объектов на основании ID
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is IdentifiableEntity<T>))
                return false;
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (this.GetType() != obj.GetType())
                return false;
            IdentifiableEntity<T> item = (IdentifiableEntity<T>)obj;

            if (item.IsTransient || this.IsTransient)
                return false;
            else
                return item.Id.Equals(this.Id);
        }

        /// <summary>
        /// Хэш-код сущности, основанный на ID
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ 31;
        }

        public static bool operator ==(IdentifiableEntity<T> left, IdentifiableEntity<T> right)
        {
            if (Object.Equals(left, null))
                return (Object.Equals(right, null)) ? true : false;
            else
                return left.Id.Equals(right.Id);
        }
        public static bool operator !=(IdentifiableEntity<T> left, IdentifiableEntity<T> right)
        {
            return !(left == right);
        }
    }
}
