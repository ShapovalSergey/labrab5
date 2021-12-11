using System;
using System.Collections.Generic;
using System.Text;
namespace labrab5
{
	public class league
	{

		private string name;
		private int value_of_teams;
		private string years;
		private string location;
		private team tm;
		//////////////////////////func
		public void Addteam(team a)
		{
			tm = a;
		}
		public league() { }

		
		public league(string name1, int value_of_teams1, string  years1, string location1)
		{
			name = name1;
			value_of_teams = value_of_teams1;
			years = years1;
			location = location1;
		}

		public string Name
		{
			set { name = value; }
			get { return name; }
		}
		public string Years
		{
			set { years = value; }
			get { return years; }
		}
		public string Location
		{
			set { location = value; }
			get { return location; }
		}
		public int Value_of_teams
		{
			set
			{
				if (value < 0)
					Console.WriteLine("Количество команд не может быть отрицательным числом");
				else
					value_of_teams = value;
			}
			get { return value_of_teams; }
		}
		//~league();
		public void teamvivod()
		{
		
			Console.WriteLine(tm.Name+"\n");
		}
		public void vivod() { Console.WriteLine( name+" "+ value_of_teams + " " + years + " " + location+"\n"); }
    }
}
