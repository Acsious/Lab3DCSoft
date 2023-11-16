namespace Lab3;

internal class Car
{
    public IMovable Movable { private get; set; }
    protected int passengers;
    protected string model;

    public Car(int num, string modelName, IMovable mov)
    {
        this.passengers = num;
        this.model = modelName;
        Movable = mov;
    }

    public void Move() => Movable.Move();
}
