using System;

interface ICar
{
    void go();
}

class Plane
{
    public virtual void fly()
    {
        Console.WriteLine("Plane fly.");
    }
}

abstract class ACar : Plane, ICar
{
    public abstract void go();

    public override void fly()
    {
        Console.WriteLine("A Car fly");
    }

    void openDoor()
    {

    }
}

class RedCar : ACar
{
    public override void go()
    {
        throw new NotImplementedException();
    }


}

namespace testabstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane car = new RedCar();
            car.fly();
        }
    }
}
