using ProjectOOP.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOOP.models
{
	internal class Manager : Employee, IReportable 
	{
		public int TeamSize{  get;  }
		public Manager(int id, string name , decimal salary, int teamSize) : base(id, name, salary) 
		{
			TeamSize = teamSize;
		}
		public override void Work()
		{
			Console.WriteLine($"Менеджер: {Name}\nУправляет командой из:{TeamSize}");
		}
		public void GenerateReport() // без слова override, потому что это интерфейс
		{
			Console.WriteLine($"ОТЧЕТ: Менеджер {Name} управляет {TeamSize} сотрудниками");
		}
	}
}
