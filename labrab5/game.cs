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
			league_name = name;
			home_team = home;
			visitor_team = vis;
			result = rez;
		}
		public void change_name(string name1)
		{
			league_name = name1;
		}
		public void change_home_team(string home_team1)
		{
			home_team = home_team1;
		}
		public void change_visitor_team(string visitor_team1)
		{
			visitor_team = visitor_team1;
		}
		public void change_result(string result1)
		{
			result = result1;
		}
		public string return_name() { return league_name; }
		public string return_home_team() { return home_team; }
		public string return_visitor_team() { return visitor_team; }
		public string return_result() { return result; }
		public void vivod() { Console.WriteLine(league_name + " " + home_team + " " + result + " " + visitor_team + "\n"); }
	}
}
