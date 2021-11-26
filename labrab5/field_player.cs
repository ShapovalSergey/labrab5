using System;
using System.Collections.Generic;
using System.Text;

namespace labrab5
{
    public class field_player
    {

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

		public field_player() { }
		public field_player(string name1, int age1, int games1, int goals1, int assists1, int red1, int yellow1, string position1, string nation1, int weig1, int heig1)
		{
			name = name1;
			nation = nation1;
			age = age1;
			games = games1;
			goals = goals1;
			assists = assists1;
			red_cards = red1;
			yellow_cards = yellow1;
			position = position1;
			weight = weig1;
			height = heig1;
		}
		public void change_name(string name1)
		{
			name = name1;
		}
		public void change_position(string position1)
		{
			position = position1;
		}
		public void change_nation(string nation1)
		{
			nation = nation1;
		}
		public void change_games(int games1)
		{
			games = games1;
		}
		public void change_goals(int goals1)
		{
			goals = goals1;
		}
		public void change_age(int age1)
		{
			age = age1;
		}
		public void change_red_cards(int red_cards1)
		{
			red_cards = red_cards1;
		}
		public void change_yellow_cards(int yellow_cards1)
		{
			yellow_cards = yellow_cards1;
		}
		public void change_weight(int weight1)
		{
			weight = weight1;
		}
		public void change_height(int height1)
		{
			height = height1;
		}
		public void change_assists(int assists1)
		{
			assists = assists1;
		}
		public string return_name() { return name; }
		public string return_nation() { return nation; }
		public int return_age() { return age; }
		public int return_games() { return games; }
		public int return_goals() { return goals; }
		public int return_assists() { return assists; }
		public int return_red_cards() { return red_cards; }
		public int return_yellow_cards() { return yellow_cards; }
		public string return_position() { return position; }
		public int return_weight() { return weight; }
		public int return_height() { return height; }
		//~field_player();
		public void vivod() { Console.WriteLine( name+" "+ nation+" "+ age+" "+ games+" "+ goals+" "+ assists+" "+ red_cards+" "+ yellow_cards+" "+ position+" "+ weight+" "+ height+"\n"); }
	}
}
