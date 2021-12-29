using System;
using System.Collections.Generic;
using System.Text;

namespace labrab5
{
	public class field_player
	{
		static int Disq = 4;
		private string name;
		private int age;
		private int games;
		private int goals;
		private int assists;
		private int red_cards;
		private int yellow_cards;
		private string position;
		private string nation;
		private int weight;
		private int height;

		//////////////////////////func
		public static int RetDisq(){return Disq;}
		public field_player() { }
		public field_player(string name1, int age1, int games1, int goals1, int assists1, int red1, int yellow1, string position1, string nation1, int weig1, int heig1)
		{
			Name = name1;
			Nation = nation1;
			Age = age1;
			//games = games1;
			Goals = goals1;
			Assists = assists1;
			Red_cards = red1;
			Yellow_cards = yellow1;
			Position = position1;
			Weight = weig1;
			Height = heig1;
		}
		public int Age
		{
			set
			{
				if (value < 16)
					Console.WriteLine("Возраст не может быть меньше 16");
				else
					age = value;
			}
			get { return age; }
		}
		public int Games
		{
			set
			{
				if (value < 0)
					Console.WriteLine("Количество матчей не может быть отрицательным числом");
				else
					games = value;
			}
			get { return games; }
		}
		public int Goals
		{
			set
			{
				if (value < 0)
					Console.WriteLine("Голы не могут быть отрицательным числом");
				else
					goals = value;
			}
			get { return goals; }
		}
		public int Assists
		{
			set
			{
				if (value < 0)
					Console.WriteLine("Ассисты не могут быть отрицательным числом");
				else
					assists = value;
			}
			get { return assists; }
		}
		public int Red_cards
		{
			set
			{
				if (value < 0)
					Console.WriteLine("Количество красных карточек не может быть отрицательным числом");
				else
					red_cards = value;
			}
			get { return red_cards; }
		}
		public int Yellow_cards
		{
			set
			{
				if (value < 0)
					Console.WriteLine("Количество желтых карточек не может быть отрицательным числом");
				else
					yellow_cards = value;
			}
			get { return yellow_cards; }
		}
		public string Position
		{
			set
			{
					position = value;
			}
			get { return position; }
		}
		public int Weight
		{
			set
			{
				if (value < 0)
					Console.WriteLine("Вес не может быть отрицательным числом");
				else
					weight = value;
			}
			get { return weight; }
		}
		public int Height
		{
			set
			{
				if (value < 0)
					Console.WriteLine("Рост не может быть отрицательным числом");
				else
					height = value;
			}
			get { return height; }
		}
		public string Name
		{
			set { name = value; }
			get { return name; }
		}
		public string Nation
		{
			set { nation = value; }
			get { return nation; }
		}
		//~field_player();
		public void vivod() { Console.WriteLine( name+" "+ nation+" "+ age+" "+ goals+" "+ assists+" "+ red_cards+" "+ yellow_cards+" "+ position+" "+ weight+" "+ height+"\n"); }
	}
}
