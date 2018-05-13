-------MIAC.Domain.Core.Abstractions.DDD v.1.0.0-------
-------------------------------------------------------

Сборка содержит дополнительные абстракции уровня ядра доменной модели согласно концепции Domain Driven Design:

Abstraction Root - представялет корень агрегации. 
	В концепции Domain Driven Design "агрегатом называется кластер из объектов сущностей [Entity] или значений [ValueObject]. 
	То есть эти объекты рассматриваются как единое целое с точки зрения изменения данных."

Value Object - представляет "объект - значение" (определение Value Object от Martin Fowler: https://martinfowler.com/bliki/ValueObject.html)

Полезные ссылки:
	1) Статья на английской вики с теорией и определениями терминов (раздел Building blocks): https://en.wikipedia.org/wiki/Domain-driven_design
	2) Хорошая статья на хабре про Domain Driven Development и все такое на русском:
		- первая часть (стратегия): https://habr.com/post/316438/
		- вторая часть (тактика): https://habr.com/post/316890/