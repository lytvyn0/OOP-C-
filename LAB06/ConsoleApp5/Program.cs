// Створіть інтерфейс IShowable з методом Show(). Реалізуйте його у класі Image, де
//метод виводить "Зображення показано". Викличте метод.
/*
using System;

interface IShowable
{
    void Show();
}

class Image : IShowable
{
    public void Show()
    {
        Console.WriteLine("Зображення показано");
    }
}

class Program
{
    static void Main()
    {
        IShowable image = new Image();
        image.Show();
    }
}
*/
// Створіть інтерфейси IConnectable та IDisconnectable. Реалізуйте обидва в класі
//Device.Продемонструйте виклики обох методів.
/*
using System;

interface IConnectable
{
    void Connect();
}

interface IDisconnectable
{
    void Disconnect();
}

class Device : IConnectable, IDisconnectable
{
    public void Connect()
    {
        Console.WriteLine("Пристрiй пiдключено");
    }

    public void Disconnect()
    {
        Console.WriteLine("Пристрiй вiдключено");
    }
}

class Program
{
    static void Main()
    {
        Device device = new Device();
        device.Connect();
        device.Disconnect();
    }
}
*/
// Створіть інтерфейс IFactory<out T> з методом T Create(). Реалізуйте його у класі
//CarFactory: IFactory<Car>.Продемонструйте присвоєння об’єкта CarFactory змінній
//типу IFactory<Vehicle>
/*
using System;
class Vehicle
{
    public virtual void Drive()
    {
        Console.WriteLine("Транспортний засiб рухається");
    }
}

class Car : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Автомобiль рухається");
    }
}


interface IFactory<out T>
{
    T Create();
}


class CarFactory : IFactory<Car>
{
    public Car Create()
    {
        return new Car();
    }
}

class Program
{
    static void Main()
    {
        IFactory<Car> carFactory = new CarFactory();
        IFactory<Vehicle> vehicleFactory = carFactory; 

        Vehicle vehicle = vehicleFactory.Create();
        vehicle.Drive();
    }
}
*/