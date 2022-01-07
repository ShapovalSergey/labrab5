using System;
using System.Collections.Generic;
using System.Text;

namespace labrab5
{
    public class player:human
    {
        protected string name;
		protected int age;
		protected string nation;
		public player():base(1) { }
		public player(string name1, int age1, string nation1) : base(1)
		{
			name = name1;
			age = age1;
			nation = nation1;
		}
		public void Plus_age(int plus) { age += plus; }
		public void Minus_age(int minus) { age -= minus; }
		public virtual string ReturnPosition() { return "Неизвестно"; }
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
		public override string CreateStatus() 
		{
			return "Профессиональный игрок";
		}
	}
}
