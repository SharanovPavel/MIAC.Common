-------MIAC.Domain.Infrastructure.Interfaces v.1.0.0-------
-----------------------------------------------------------

Содержит описание интерфейсов уровня инфраструктуры домена:

Repository

	- ICanFindEntities - предоставляет обобщенный интерфейс для поиска сущностей, имеющий локальный идентификатор, в хранилище
	- ICanFindEntitiesByExpression - предоставляет обобщенный интерфейс для поиска сущностей, имеющий локальный идентификатор, в хранилище
	- ICanFindEntitiesByGuid - предоставляет интерфейс для поиска сущностей по гобальному идентификатору (GUID)
	
	- ICanInsertEntities - предоставляет обобщенный интерфейс для добавления сущностей в хранилище

	- ICanRemoveEntities - предоставляет обобщенный интерфейс для удаления сущности из хранилища
	- ICanRemoveEntities - предоставляет обобщенный интерфейс для удаления сущности из хранилища по идентификатору
	- ICanRemoveEntitiesByGuid - предоставляет интерфейс для удаления сущности из хранилища по глобальному идентификатору

	- ICanSelectAllEntities - предоставляет интерфейс для выгрузки всех сущностей из хранилища
		- Обобщенный интферейс ICanSelectAllEntities<T> следует использовать в типизированных хранилищах (например, EmployeeRepository : ICanSelectAllEntities<Employee>)
		- Интерфейс ICanSelectAllEntities следует использовать в реализациях контекста данных (например, SubventionsDbContext : ICanSelectAllEntities).
			- В Entity Framework и EF Core данный интерфейс уже неявно реализован с помощью DataSet<T> - свойств

	- ICanUpdateEntities - предоставляет интерфейс для обновления состояния сущности в хранилище

- IUnitOfWork - представляет интерфейс паттерна "единица работы" (http://design-pattern.ru/patterns/unit-of-work.html)
	 - наследует интерфейс ICreator<IUnitOfWork>
	 - Пример использования:
		//concreteUnitOfWorkFactory = GetUnitOfWorkFactory();
		//...
		using(ConcreteUnitOfWOrk uof = concreteUnitOfWorkFactory.Create())
		{
			try
			{
				//Действия в рамках единицы работы
				
				uof.Commit();
			}
			catch(Exception e)
			{
				Logger.Fail(e);
				uof.Rollback();
			}
		}