using System;
using System.Collections.Generic;
using System.Text;

namespace labrab5
{
	public class game:ICloneable
	{
		private league lg;
		private string home_team;
		private string visitor_team;
		private string result;
		//////////////////////////func
		public game() { }
		public game(league lg, string rez, string vis, string home)
		{
			this.lg=lg;
			Home_team = home;
			Visitor_team = vis;
			Result = rez;
		}
		public game(string res) { Result = res; }
		public league Lg
		{
			set { lg = value; }
			get { return lg; }
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
		public void Vivod() { Console.WriteLine(lg.Name + " " + home_team + " " + result + " " + visitor_team + "\n"); }
		public object Clone(){ return MemberwiseClone(); }
		//public object Clone() { return new game(new league(lg.Name), Result,Visitor_team, Home_team ); }

	}
}
