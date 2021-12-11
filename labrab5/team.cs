using System;
using System.Collections.Generic;
using System.Text;

namespace labrab5
{
	public struct team
	{
		private string name;
		private int wins;
		private int defeats;
		private int draws;
		private int value_of_field_players;
		private int value_of_goalkeepers;
		private string location;
		//////////////////////////func
		//public team() { }
		public team(string name1, int wins1, int defeats1, int draws1, int val_of_fp, int val_of_gk, string location1)
		{

			name = name1;
			wins = wins1;
			defeats = defeats1;
			draws = draws1;
			value_of_field_players = val_of_fp;
			value_of_goalkeepers = val_of_gk;
			location = location1;
		}
		public string Name
		{
			set { name = value; }
			get { return name; }
		}
		public int Defeats
		{
			set {
				if (value < 0)
					Console.WriteLine("Поражения не могут быть отрицательным числом");
				else
					 defeats = value;
			}
			get { return defeats; }
		}
		public int Draws
		{
			set
			{
				if (value < 0)
					Console.WriteLine("Ничьи не могут быть отрицательным числом");
				else
					draws = value;
			}
			get { return draws; }
		}
		public int Wins
		{
			set
			{
				if (value < 0)
					Console.WriteLine("Победы не могут быть отрицательным числом");
				else
					wins = value;
			}
			get { return wins; }
		}
		public int Value_of_field_players
		{
			set
			{
				if (value < 16)
					Console.WriteLine("Количество полевых игроков не может быть меньше 16");
				else
					value_of_field_players = value;
			}
			get { return value_of_field_players; }
		}
		public int Value_of_goalkeepers
		{
			set
			{
				if (value < 2)
					Console.WriteLine("Количество вратарей не может быть меньше 2");
				else
					value_of_goalkeepers = value;
			}
			get { return value_of_goalkeepers; }
		}
		public string Location
		{
			set { location = value; }
			get { return location; }
		}
	 public void vivod() { Console.WriteLine( name + " " + defeats+" "+ wins+" "+ draws+" "+ value_of_field_players+" "+ value_of_goalkeepers+" "+ location+"\n"); }
}
}
