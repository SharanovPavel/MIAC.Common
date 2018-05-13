using System;

namespace MIAC.Domain.Core.Interfaces
{
    /// <summary>
    /// Представляет интерфейс глобального идентификатора
    /// </summary>
    public interface IHasGlobalIdentity
    {
        /// <summary>
        /// Глобальный идентификатор
        /// </summary>
        Guid GlobalId { get; set; }
    }
}
