using System;

namespace MIAC.Domain.Core.Interfaces
{
    /// <summary>
    /// Определяет интерфейсы временных меток создания и модификации
    /// </summary>
    public interface IHasTimeStamps:
        IHasCreationDate, 
        IHasUpdatedDate
    {

    }

    /// <summary>
    /// Определяет интерфейс временной метки создания
    /// </summary>
    public interface IHasCreationDate
    {
        /// <summary>
        /// Время создания объекта
        /// </summary>
        DateTime Created { get; set; }
    }

    /// <summary>
    /// Определяет интерфейс временной метки модификации
    /// </summary>
    public interface IHasUpdatedDate
    {
        /// <summary>
        /// Время псоледнего модификации состояния объекта
        /// </summary>
        DateTime Updated { get; set; }
    }
}
