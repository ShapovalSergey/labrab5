using System;
using System.Collections.Generic;
using System.Text;

namespace labrab5
{
	public class game
	{
		private string league_name;
		private string home_team;
		private string visitor_team;
		private string result;
		//////////////////////////func
		public game() { }
		public game(string name, string rez, string vis, string home)
		{
			League_name = name;
			Home_team = home;
			Visitor_team = vis;
			Result = rez;
		}
		public game(string name) { League_name = name; }
		public string League_name
		{
			set { league_name = value; }
			get { return league_name; }
		}
		public string Home_team
		{
			set { home_team = value; }
			get { return home_team; }
		}
		public string Visitor_team
		{
			set { visitor_team = value; }
			get { return visitor_team; }
		}
		public string Result
		{
			set { result = value; }
			get { return result; }
		}
		public void Vivod() { Console.WriteLine(league_name + " " + home_team + " " + result + " " + visitor_team + "\n"); }
	}
}
