using System;
using System.Collections.Generic;
using System.Text;

namespace labrab5
{
	public struct game
	{
		private string league_name;
		private string home_team;
		private string visitor_team;
		private string result;
		//////////////////////////func
		//public game() { }


		public static game operator +(game g1, game g2)
		{
			game g3 = new game();
			g3.League_name = g1.League_name + g2.League_name;
			g3.Home_team = g1.Home_team + g2.Home_team;
			g3.Visitor_team = g1.Visitor_team + g2.Visitor_team;
			g3.Result = g1.Result + g2.Result;
			return g3;
		}



		public game(string league_name, string result, string visitor_team, string home_team)
		{
			this.league_name = league_name;
			this.home_team = home_team;
			this.visitor_team = visitor_team;
			this.result = result;
		}
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
		public void vivod() { Console.WriteLine(league_name + " " + home_team + " " + result + " " + visitor_team + "\n"); }
	}
}
