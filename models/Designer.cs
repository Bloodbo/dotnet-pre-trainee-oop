using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOOP.models
{
	internal class Designer : Employee
	{
		public string DesignTool{  get; }
		public Designer(int id, string name, decimal salary, string designTool) : base(id, name, salary)
		{
			DesignTool = designTool;
		}
		public override void Work()
		{
			Console.WriteLine($"Дизайнер: {Name}\nРаботает в: {DesignTool}");
		}
		
	}
}
