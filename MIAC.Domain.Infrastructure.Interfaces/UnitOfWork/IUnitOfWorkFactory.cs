using MIAC.Patterns.Creational;

namespace MIAC.Domain.Infrastructure.Interfaces.Repository
{
    interface IUnitOfWorkFactory:ICreator<IUnitOfWork>
    {
    }
}
