using System;
using System.Collections.Generic;
using System.Text;

namespace labrab5
{
	public class team: ILicense
	{
		static int n=0;
		private string name;
		private int wins;
		private int defeats;
		private int draws;
		private int value_of_field_players;
		private int value_of_goalkeepers;
		private string location;
		//////////////////////////func
		public static int ReturnN() { return n; }
		public team() { n++; }
		public team(string name1, int wins1, int defeats1, int draws1, int val_of_fp, int val_of_gk, string location1)
		{

			Name = name1;
			Wins = wins1;
			Defeats = defeats1;
			Draws = draws1;
			Value_of_field_players = val_of_fp;
			Value_of_goalkeepers = val_of_gk;
			Location = location1;
			n++;
		}
		public team(string name1) { Name = name1; n++; }
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
			//	if (value < 0)
			//		Console.WriteLine("Ничьи не могут быть отрицательным числом");
			//	else
					draws = value;
			}
			get { return draws; }
		}
		public int Wins
		{
			set
			{
				//if (value < 0)
					//Console.WriteLine("Победы не могут быть отрицательным числом");
				//else
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
	 public void Vivod() { Console.WriteLine( name + " " + defeats+" "+ wins+" "+ draws+" "+ value_of_field_players+" "+ value_of_goalkeepers+" "+ location+"\n"+"Количество очков = "+Stat()); }
		public int Stat()
		{
			int points;
            try
            {
				if ((Wins < 0) || (Draws < 0))
				{
					throw new Exception("Не удается получить корректный результат");
				}
                else
                {
					points = Wins * 3 + Draws;
                }
				
			}
            catch (Exception e)
            {

				Console.WriteLine($"Ошибка: {e.Message}");
				points = 2147483647;
			}
			
			
			return points; 
		}
		public void GetLicense() { Console.WriteLine("Лицензия команды - 123456789"); }
	}
}
