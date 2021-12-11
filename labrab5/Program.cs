using System;

namespace labrab5
{
    class Program
    { public static void input_full_league(league a)
        {
            string im, loc, season; int i;
            Console.WriteLine("Введите название лиги\n");
            im = Console.ReadLine();
            a.Name=im;
            Console.WriteLine("Введите количество команд\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Value_of_teams=i;
            Console.WriteLine("Введите сезон лиги\n");
            season = Console.ReadLine();
            a.Years=season;
            Console.WriteLine("Введите страну лиги\n");
            loc = Console.ReadLine();
            a.Location=loc;
        }

        public static void input_full_team(team a)
        {
            string im, loc; int i;
            Console.WriteLine("Введите название команды\n");
            im = Console.ReadLine();
            a.Name=im;
            Console.WriteLine("Введите количество побед\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Wins=i;
            Console.WriteLine("Введите количество поражений\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Defeats=i;
            Console.WriteLine("Введите количество ничьих\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Draws=i;
            Console.WriteLine("Введите количество полевых игроков\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Value_of_field_players=i;
            Console.WriteLine("Введите количество вратарей\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Value_of_goalkeepers=i;
            Console.WriteLine("Введите город команды\n");
            loc = Console.ReadLine();
            a.Location=loc;
        }

        public static void input_full_gp(goalkeeper a)
        {
            string im, loc; int i;
            Console.WriteLine("Введите имя вратаря\n");
            im = Console.ReadLine();
            a.Name=im;
            Console.WriteLine("Введите возраст\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Age=i;
            Console.WriteLine("Введите количество голов вратаря\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Goals=i;
            Console.WriteLine("Введите количество асистов вратаря\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Assists=i;
            Console.WriteLine("Введите количество красных карточек\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Red_cards=i;
            Console.WriteLine("Введите количество желтых карточек\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Yellow_cards=i;
            Console.WriteLine("Введите количество пропущенных мячей\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Missed_balls=i;
            Console.WriteLine("Введите национальность вратаря\n");
            loc = Console.ReadLine();
            a.Nation=loc;
            Console.WriteLine("Введите вес вратаря\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Weight=i;
            Console.WriteLine("Введите рост вратаря\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Height=i;
        }

        public static void input_full_fp(field_player a)
        {
            string im, loc; int i; string pos;
            Console.WriteLine("Введите имя полевого игрока\n");
            im = Console.ReadLine();
            a.Name=im;
            Console.WriteLine("Введите возраст\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Age=i;
            Console.WriteLine("Введите количество голов полевого игрока\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Goals=i;
            Console.WriteLine("Введите количество асистов полевого игрока\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Assists=i;
            Console.WriteLine("Введите количество красных карточек\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Red_cards=i;
            Console.WriteLine("Введите количество желтых карточек\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Yellow_cards=i;
            Console.WriteLine("Введите позицию\n");
            pos = Console.ReadLine();
            a.Position=pos;
            Console.WriteLine("Введите национальность полевого игрока\n");
            loc = Console.ReadLine();
            a.Nation=loc;
            Console.WriteLine("Введите вес полевого игрока\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Weight=i;
            Console.WriteLine("Введите рост полевого игрока\n");
            i = Convert.ToInt32(Console.ReadLine());
            a.Height=i;
        }

        public static void input_full_game(game a)
        {
            string im;
            Console.WriteLine("Введите название лиги\n");
            im = Console.ReadLine();
            a.League_name=im;
            Console.WriteLine("Введите команду - хозяев\n");
            im = Console.ReadLine();
            a.Home_team=im;
            Console.WriteLine("Введите команду - гостей\n");
            im = Console.ReadLine();
            a.Visitor_team=im;
            Console.WriteLine("Введите результат матч\n");
            im = Console.ReadLine();
            a.Result=im;
        }

        public static void func1()
        {
            int check = 1;  int action; league a = new league();
            while (check == 1)
            {
                Console.WriteLine("Выберите, что вы хотите сделать\n1)Ввести данные лиги\n2)Изменить имя лиги\n3)Изменить количество команд\n4)Изменить сезон лиги\n5)Изменить страну лиги\n6)Вывести данные лиги\n");
                action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                {
                    input_full_league(a);
                }
                if (action == 2)
                {
                    string im;
                    Console.WriteLine("Введите название лиги\n");
                    im = Console.ReadLine();
                    a.Name=im;
                }
                if (action == 3)
                {
                    int i;
                    Console.WriteLine("Введите количество команд\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Value_of_teams=i;
                }
                if (action == 4)
                {
                    string season;
                    Console.WriteLine("Введите сезон лиги\n");
                    season = Console.ReadLine();
                    a.Years=season;
                }
                if (action == 5)
                {
                    string loc;
                    Console.WriteLine("Введите страну лиги\n");
                    loc = Console.ReadLine();
                    a.Location=loc;
                }
                if (action == 6)
                {
                    a.vivod();
                }
                Console.ReadKey();
                Console.WriteLine("\nВы хотите продолжить с этим классом? 1 - да, 0 - нет ");
                check = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void func2()
        {
            int check = 1;  int action; team a=new team();
            while (check == 1)
            {
               
           
                    Console.WriteLine("Выберите, что вы хотите сделать\n1)Ввести данные команды\n2)Изменить название команды\n3)Изменить количество побед команды\n4)Изменить количество поражений команды\n5)Изменить количество ничьих команды\n6)Изменить количество полевых игроков\n7)Изменить количество вратарей\n8)Изменить город команды\n9)Вывести данные команды\n");
                    action=Convert.ToInt32(Console.ReadLine());
                    if (action == 1)
                    {
                        input_full_team(a);
                    }
                    if (action == 2)
                    {
                        string im;
                        Console.WriteLine("Введите название команды\n");
                        im=Console.ReadLine();
                        a.Name=im;
                    }
                    if (action == 3)
                    {
                        int i;
                        Console.WriteLine("Введите количество побед\n");
                        i= Convert.ToInt32(Console.ReadLine());
                        a.Wins=i;
                    }
                    if (action == 4)
                    {
                        int i;
                        Console.WriteLine("Введите количество поражений\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Defeats=i;
                    }
                    if (action == 5)
                    {
                        int i;
                        Console.WriteLine("Введите количество ничьих\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Draws=i;
                    }
                    if (action == 6)
                    {
                        int i;
                        Console.WriteLine("Введите количество полевых игроков\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Value_of_field_players=i;
                    }
                    if (action == 7)
                    {
                        int i;
                        Console.WriteLine("Введите количество вратарей\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Value_of_goalkeepers=i;
                    }
                    if (action == 8)
                    {
                        string loc;
                        Console.WriteLine("Введите город команды\n");
                        loc=Console.ReadLine();
                        a.Location=loc;
                    }
                    if (action == 9)
                    {
                        a.vivod();
                    }
                Console.ReadKey();
                Console.WriteLine("\nВы хотите продолжить с этим классом? 1 - да, 0 - нет ");
                check = Convert.ToInt32(Console.ReadLine());
            }
}


        public static void func3()
        {
            int check = 1;  int action; goalkeeper a=new goalkeeper();
            while (check == 1)
            {
                    Console.WriteLine("Выберите, что вы хотите сделать\n1)Ввести  данные вратаря\n2)Изменить имя вратаря\n3)Изменить возраст вратаря\n4)Изменить количество голов вратаря\n5)Изменить количество асистов вратаря\n6)Изменить количество красных карточек\n7)Изменить количество желтых карточек\n8)Изменить количество пропущенных мячей\n9)Изменить национальность вратаря\n10)Изменить вес вратаря\n11)Изменить рост вратаря\n12)Вывести данные вратаря\n");
                action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                    {
                        input_full_gp(a);
                    }
                    if (action == 2)
                    {
                        string im;
                        Console.WriteLine("Введите имя вратаря\n");
                       im =Console.ReadLine();
                        a.Name=im;
                    }
                    if (action == 3)
                    {
                        int i;
                        Console.WriteLine("Введите возраст\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Age=i;
                    }
                    if (action == 4)
                    {
                        int i;
                        Console.WriteLine("Введите количество голов вратаря\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Goals=i;
                    }
                    if (action == 5)
                    {
                        int i;
                        Console.WriteLine("Введите количество асистов вратаря\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Assists=i;
                    }
                    if (action == 6)
                    {
                        int i;
                        Console.WriteLine("Введите количество красных карточек\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Red_cards=i;
                    }
                    if (action == 7)
                    {
                        int i;
                        Console.WriteLine("Введите количество желтых карточек\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Yellow_cards=i;
                    }
                    if (action == 8)
                    {
                        int i;
                        Console.WriteLine("Введите количество пропущенных мячей\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Missed_balls=i;
                    }
                    if (action == 9)
                    {
                        string loc;
                        Console.WriteLine("Введите национальность вратаря\n");
                        loc=Console.ReadLine();
                        a.Nation=loc;
                    }
                    if (action == 10)
                    {
                        int i;
                        Console.WriteLine("Введите вес вратаря\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Weight=i;
                    }
                    if (action == 11)
                    {
                        int i;
                        Console.WriteLine("Введите рост вратаря\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Height=i;
                    }
                    if (action == 12)
                    {
                        a.vivod();
                    }
                Console.ReadKey();
                    Console.WriteLine("\nВы хотите продолжить с этим классом? 1 - да, 0 - нет ");
                check = Convert.ToInt32(Console.ReadLine());
            }
                
        }

        public static void func4()
        {
            int check = 1;  int action; field_player a=new field_player();
            while (check == 1)
            {
               
                
                    Console.WriteLine("Выберите, что вы хотите сделать\n1)Ввести  данные полевого игрока\n2)Изменить имя полевого игрока\n3)Изменить возраст полевого игрока\n4)Изменить количество голов полевого игрока\n5)Изменить количество асистов полевого игрока\n6)Изменить количество красных карточек\n7)Изменить количество желтых карточек\n8)Изменить позицию\n9)Изменить национальность полевого игрока\n10)Изменить вес полевого игрока\n11)Изменить рост полевого игрока\n12)Вывести данные полевого игрока\n");
                action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                    {
                        input_full_fp(a);
                    }
                    if (action == 2)
                    {
                        string im;
                        Console.WriteLine("Введите имя полевого игрока\n");
                        im=Console.ReadLine();
                        a.Name=im;
                    }
                    if (action == 3)
                    {
                        int i;
                        Console.WriteLine("Введите возраст\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Age=i;
                    }
                    if (action == 4)
                    {
                        int i;
                        Console.WriteLine("Введите количество голов полевого игрока\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Goals=i;
                    }
                    if (action == 5)
                    {
                        int i;
                        Console.WriteLine("Введите количество асистов полевого игрока\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Assists=i;
                    }
                    if (action == 6)
                    {
                        int i;
                        Console.WriteLine("Введите количество красных карточек\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Red_cards=i;
                    }
                    if (action == 7)
                    {
                        int i;
                        Console.WriteLine("Введите количество желтых карточек\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Yellow_cards=i;
                    }
                    if (action == 8)
                    {
                        string pos;
                        Console.WriteLine("Введите позицию\n");
                       pos =Console.ReadLine();
                        a.Position=pos;
                    }
                    if (action == 9)
                    {
                        string loc;
                        Console.WriteLine("Введите национальность полевого игрока\n");
                        loc=Console.ReadLine();
                        a.Nation=loc;
                    }
                    if (action == 10)
                    {
                        int i;
                        Console.WriteLine("Введите вес полевого игрока\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Weight=i;
                    }
                    if (action == 11)
                    {
                        int i;
                        Console.WriteLine("Введите рост полевого игрока\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    a.Height=i;
                    }
                    if (action == 12)
                    {
                        a.vivod();
                    }
                Console.ReadKey();
                    Console.WriteLine("\nВы хотите продолжить с этим классом? 1 - да, 0 - нет ");
                check = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void func5()
        {
            int check = 1;  int action;game a=new game();
            while (check == 1)
            {
                    Console.WriteLine("Выберите, что вы хотите сделать\n1)Ввести данные матча\n2)Изменить название лиги\n3)Изменить команду - хозяев\n4)Изменить команду - гостей\n5)Изменить результат матча\n6)Вывести данные матча\n");
                action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                    {
                        input_full_game(a);
                    }
                    if (action == 2)
                    {
                        string im;
                        Console.WriteLine("Введите название лиги\n");
                    im = Console.ReadLine();
                    a.League_name=im;
                    }
                    if (action == 3)
                    {
                        string im;
                        Console.WriteLine("Введите команду - хозяев\n");
                    im = Console.ReadLine();
                    a.Home_team=im;
                    }
                    if (action == 4)
                    {
                        string im;
                        Console.WriteLine("Введите команду - гостей\n");
                        im=Console.ReadLine();
                        a.Visitor_team=im;
                    }
                    if (action == 5)
                    {
                        string im;
                        Console.WriteLine("Введите результат матч\n");
                       im =Console.ReadLine();
                        a.Result=im;
                    }
                    if (action == 6)
                    {
                        a.vivod();
                    }
                Console.ReadKey();
                    Console.WriteLine("\nВы хотите продолжить с этим классом? 1 - да, 0 - нет ");
                check = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            int mode; int check = 1;
            while (check == 1)
            {
               Console.WriteLine("Выберите с каким классом вы хотите работать\n1)Лига\n2)Команда\n3)Вратари\n4)Полевые\n5)Игры\n");
                mode = Convert.ToInt32(Console.ReadLine());
                if (mode == 1)
                {
                    func1();
                }
                if (mode == 2)
                {
                    func2();
                }
                if (mode == 3)
                {
                    func3();
                }
                if (mode == 4)
                {
                    func4();
                }
                if (mode == 5)
                {
                    func5();
                }
                Console.WriteLine("Вы хотите продолжить? 1 - да, 0 - нет ");
                check = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
