using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOOP.models
{
	abstract class Employee
	{
		public int Id { get; private set; } // снаружи читать можно, менять - только внутри
		public string Name { get; private set; }
		public decimal Salary { get; private set; } // меняется только через метод ChangeSalary
		public Employee(int id, string name, decimal salary)
		{
			if(!string.IsNullOrEmpty(name) &&
			salary > 0)
			{
				Id = id;
				Name = name;
				Salary = salary;
			}
		}
		public abstract void Work();
		public event Action<decimal> SalaryChanged;
		public void ChangeSalary(decimal newSalary)
		{
			if (newSalary < 0)
			{
				Console.WriteLine("Ошибка: Зарплата не может быть отрицательной.");
				return; // выходим, ничего не меняем
			}

			Salary = newSalary; // меняем
			SalaryChanged?.Invoke(Salary); // оповещаем всех, кто подписан
		}
	}
}
