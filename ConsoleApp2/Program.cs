/*
 Создать базовый класс "Устройство" и производные классы:
"Чайник", "Микроволновка", "Автомобиль", "Пароход".
С помощью конструктора, установить название к каждому
устройству и его характеристики.
Реализуйте для каждого из классов методы:
■ Sound - выдает звук устройства (пишем текстом в
консоль);
■ Show - отображает название устройства;
■ Desc - отображает описание устройства.
*/

namespace ConsoleApp2
{
    public abstract class Device
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Device(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public abstract void Sound();

        public void Show()
        {
            Console.WriteLine($"Название устройства: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Описание устройства: {Description}");
        }
    }

    internal class Kettle : Device
    {
        public Kettle(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Чайник свистит");
        }
    }

    public class Microwave : Device
    {
        public Microwave(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Микроволновка издает звуковой сигнал");
        }
    }

    public class Car : Device
    {
        public Car(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Автомобиль издает звук двигателя");
        }
    }

    public class Steamer : Device
    {
        public Steamer(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Пароход гудит");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Kettle kettle = new Kettle("Чайник", "Это устройство для кипячения воды.");
            Microwave microwave = new Microwave("Микроволновка", "Это устройство для разогрева пищи.");
            Car car = new Car("Автомобиль", "Это транспортное средство для передвижения по дорогам.");
            Steamer steamer = new Steamer("Пароход", "Это судно с паровым двигателем.");

            kettle.Show();
            kettle.Desc();
            kettle.Sound();

            Console.WriteLine("\n=============================\n");

            microwave.Show();
            microwave.Desc();
            microwave.Sound();

            Console.WriteLine("\n=============================\n");

            car.Show();
            car.Desc();
            car.Sound();

            Console.WriteLine("\n=============================\n");

            steamer.Show();
            steamer.Desc();
            steamer.Sound();
        }
    }
}