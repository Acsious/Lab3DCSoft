using Lab3;

Car auto = new(4, "Volvo", new PetrolMove());
auto.Move();
auto.Movable = new ElectricMove();
auto.Move();

Console.ReadLine();