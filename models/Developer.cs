using ProjectOOP.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOOP.models
{
	internal class Developer : Employee, IReportable // подключаем интерфейс к классу 
	{
		public string ProgrammingLanguage {  get; }
		public Developer(int id, string name, decimal salary, string programmingLanguage) : base(id, name, salary)
		{
			ProgrammingLanguage = programmingLanguage;
		}
		public override void Work()
		{
			Console.WriteLine($"Разработчик {Name}\nСтек: {ProgrammingLanguage}");
		}
		public void GenerateReport() // без слова override, потому что это интерфейс
		{
			Console.WriteLine($"ОТЧЕТ: Разработчик {Name} пишет на {ProgrammingLanguage}");
		}
	}
}
