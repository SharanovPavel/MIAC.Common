using System;

namespace MIAC.Domain.Infrastructure.Interfaces
{
    /// http://design-pattern.ru/patterns/unit-of-work.html
    /// <summary>
    /// Представляет интерфейс паттерна "единица работы"
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Сохраняет сделанные изменения
        /// </summary>
        /// <returns>Количество измененных записей</returns>
        void Commit();

        /// <summary>
        /// Откатывает совершенные изменения
        /// </summary>
        void Rollback();
    }
}
