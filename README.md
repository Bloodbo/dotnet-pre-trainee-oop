# Employee Management System (OOP Mini Project)

Консольное приложение для управления сотрудниками.

## Реализованные типы сотрудников
* Developer
* Manager
* Designer

## OOP Concepts Used (Использованные концепции ООП)
* **Encapsulation (Инкапсуляция):** Свойства защищены (`private set`), изменение зарплаты происходит только через метод `ChangeSalary`.
* **Inheritance (Наследование):** Классы Developer, Manager, Designer наследуются от абстрактного класса Employee.
* **Polymorphism (Полиморфизм):** Работа с разными типами сотрудников через `List<Employee>` и вызов `Work()`.
* **Abstraction (Абстракция):** Абстрактный класс Employee с абстрактным методом Work().
* **Interfaces (Интерфейсы):** Интерфейс IReportable реализован в Manager и Developer.
* **Events (События):** Событие SalaryChanged, на которое подписываются через лямбда-выражение.

## Как запустить
1. Открыть решение в Visual Studio.
2. Нажать F5 (Start Debugging).
