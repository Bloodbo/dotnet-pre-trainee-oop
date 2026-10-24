using ProjectOOP.interfaces;
using ProjectOOP.models;
using System;
namespace ProjectOOP;
internal class Program
{
	private static void Main(string[] args)
	{
		List<Employee> employees = new List<Employee>();
		Manager manager = new Manager(2,"Alex", 5000, 13);
		Developer developer = new Developer(1,"Ilya", 3500, ".NET platform");
		Designer designer = new Designer(1, "Darya", 2455, "CapCut");
		employees.Add(manager);
		employees.Add(developer);
		employees.Add(designer);
		
		// 1. Подписываемся на событие через лямбду
		manager.SalaryChanged += (newSalary) =>
		{
			Console.WriteLine($"ВНИМАНИЕ! Зарплата {manager.Name} изменена. Новая зарплата: {newSalary}");
		};

		// 2. Меняем зарплату (это вызовет событие)
		manager.ChangeSalary(7500);

		// 3. Попробуем ввести отрицательную зарплату (событие не должно сработать)
		manager.ChangeSalary(-500);

		bool isRunning = true;

		while (isRunning)
		{
			Console.WriteLine("\n--- МЕНЮ ---");
			Console.WriteLine("1. Показать всех сотрудников (Work)");
			Console.WriteLine("2. Сгенерировать отчеты (IReportable)");
			Console.WriteLine("3. Изменить зарплату сотрудника");
			Console.WriteLine("0. Выход");
			Console.Write("Выберите действие: ");

			string choice = Console.ReadLine() ?? "0";
			if (int.TryParse(choice, out int choiceProof))
			{
				switch (choiceProof)
				{
					case 1:
						{
							foreach (var emp in employees)
							{
								emp.Work();
							}
							break;
						}

					case 2:
						foreach (var emp in employees)
						{
							if (emp is IReportable reportable)
							{ // проверка относится ли к интерфейсу тот или иной сотрудник и если да , то генерируем отчёт
								reportable.GenerateReport();
							}
						}
						break;

					case 3:
						Console.Write("Введите имя сотрудника: ");
						string empName = Console.ReadLine() ?? "None";
						Console.Write("Введите новую зарплату: ");
						string newSal = Console.ReadLine() ?? "None";

						// Используй int.TryParse или decimal.TryParse, чтобы программа не упала, если введут буквы
						if (decimal.TryParse(newSal, out decimal newSalProof))
						{
							// находим сотрудника по имени и вызови ChangeSalary
							var empToChange = employees.FirstOrDefault(e => e.Name == empName);
							if (empToChange != null)
							{
								empToChange.ChangeSalary(newSalProof);
							}
							else
							{
								Console.WriteLine("Сотрудник не найден");
							}
						}
						else
						{
							Console.WriteLine("Ошибка: введите число!");
						}
						break;

					case 0:
						{
							isRunning = false;
							Console.WriteLine("Выход из программы...");
							break;
						}

					default:
						{
							Console.WriteLine("Неверный пункт меню. Попробуйте снова.");
							break;
						}
				}
			}
			else
			{
				Console.WriteLine($"ваш ввод неправильный: {choice}");
			}
		}

	}
}