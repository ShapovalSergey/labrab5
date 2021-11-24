using System;
using System.Collections.Generic;
using System.Text;
namespace labrab5
{
    class league
    {
		
		private string name;
		private int value_of_teams;
		private string years;
		private string location;
		private team tm;
		//////////////////////////func
			public void Addteam(team a)
			{
			tm=a;
			}
		public league() { }
		public league(string name1, int value_of_teams1, string  years1, string location1)
		{
			name = name1;
			value_of_teams = value_of_teams1;
			years = years1;
			location = location1;
		}
	public void change_name(string name1)
	{
		name = name1;
	}
		public void change_value(int value)
	{
		value_of_teams = value;
	}
		public void change_years(string years1)
	{
		years = years1;
	}
		public void change_loc(string location1)
	{
		location = location1;
	}
		public string return_name()
	{
		return name;
	}
		public int return_value()
	{
		return value_of_teams;
	}
		public string return_years()
	{
		return years;
	}
		public string return_location()
	{
		return location;
	}
		//~league();
		public void teamvivod()
		{
		
			Console.WriteLine(tm.return_name()+"\n");
		}
		public void vivod() { Console.WriteLine( name+" "+ value_of_teams + " " + years + " " + location+"\n"); }
    }
}
