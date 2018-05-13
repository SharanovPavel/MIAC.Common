-------MIAC.Domain.Infrastructure.Interfaces v.1.0.0-------
-----------------------------------------------------------

�������� �������� ����������� ������ �������������� ������:

Repository

	- ICanFindEntities - ������������� ���������� ��������� ��� ������ ���������, ������� ��������� �������������, � ���������
	- ICanFindEntitiesByExpression - ������������� ���������� ��������� ��� ������ ���������, ������� ��������� �������������, � ���������
	- ICanFindEntitiesByGuid - ������������� ��������� ��� ������ ��������� �� ���������� �������������� (GUID)
	
	- ICanInsertEntities - ������������� ���������� ��������� ��� ���������� ��������� � ���������

	- ICanRemoveEntities - ������������� ���������� ��������� ��� �������� �������� �� ���������
	- ICanRemoveEntities - ������������� ���������� ��������� ��� �������� �������� �� ��������� �� ��������������
	- ICanRemoveEntitiesByGuid - ������������� ��������� ��� �������� �������� �� ��������� �� ����������� ��������������

	- ICanSelectAllEntities - ������������� ��������� ��� �������� ���� ��������� �� ���������
		- ���������� ��������� ICanSelectAllEntities<T> ������� ������������ � �������������� ���������� (��������, EmployeeRepository : ICanSelectAllEntities<Employee>)
		- ��������� ICanSelectAllEntities ������� ������������ � ����������� ��������� ������ (��������, SubventionsDbContext : ICanSelectAllEntities).
			- � Entity Framework � EF Core ������ ��������� ��� ������ ���������� � ������� DataSet<T> - �������

	- ICanUpdateEntities - ������������� ��������� ��� ���������� ��������� �������� � ���������

- IUnitOfWork - ������������ ��������� �������� "������� ������" (http://design-pattern.ru/patterns/unit-of-work.html)
	 - ��������� ��������� ICreator<IUnitOfWork>
	 - ������ �������������:
		//concreteUnitOfWorkFactory = GetUnitOfWorkFactory();
		//...
		using(ConcreteUnitOfWOrk uof = concreteUnitOfWorkFactory.Create())
		{
			try
			{
				//�������� � ������ ������� ������
				
				uof.Commit();
			}
			catch(Exception e)
			{
				Logger.Fail(e);
				uof.Rollback();
			}
		}