using Lab3;

Inspector instector = new(new PeopleInjured());
instector.MakeLog();
instector.Loggable = new PeopleNotInjured();
instector.MakeLog();

Console.ReadLine();