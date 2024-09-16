using System;

namespace ExampleApplication
{
    //Класс Student #1
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Course { get; set; }
        public int Age { get; set; }

        public Student(string firstName, string lastName, int course, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Course = course;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Фамилия: {LastName}, Имя: {FirstName}, Курс: {Course}, Возраст: {Age}");
        }
    }

    // Класс Computer #2
    class Computer
    {
        public string Model { get; set; }
        public int RAM { get; set; }
        public int HDD { get; set; }

        public Computer(string model, int ram, int hdd)
        {
            Model = model;
            RAM = ram;
            HDD = hdd;
        }

        public void Info()
        {
            Console.WriteLine($"Модель: {Model}, ОЗУ: {RAM} GB, Жесткий диск: {HDD} GB");
        }
    }

    // Класс Tovar #3
    class Tovar
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public int Quantity { get; set; }

        public Tovar(string name, decimal price, bool inStock, int quantity)
        {
            Name = name;
            Price = price;
            InStock = inStock;
            Quantity = quantity;
        }

        public void Kupi()
        {
            string availability = InStock ? "есть" : "нет";
            Console.WriteLine($"Название: {Name}, Цена: {Price}, Наличие на складе: {availability}, Количество: {Quantity}");
        }
    }

    // Класс Pogoda #4
    class Pogoda
    {
        public string City { get; set; }
        public int Temperature { get; set; }
        public string Precipitation { get; set; }
        public string WindDirection { get; set; }
        public int WindSpeed { get; set; }

        public Pogoda(string city, int temperature, string precipitation, string windDirection, int windSpeed)
        {
            City = city;
            Temperature = temperature;
            Precipitation = precipitation;
            WindDirection = windDirection;
            WindSpeed = windSpeed;
        }

        public void Show()
        {
            Console.WriteLine($"Город: {City}, Температура: {Temperature}°C, Осадки: {Precipitation}, Ветер: {WindDirection}, Скорость ветра: {WindSpeed} м/с");
        }
    }

    // Класс Transport #5
    class Transport
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public int Weight { get; set; }

        public Transport(string type, string color, int speed, int weight)
        {
            Type = type;
            Color = color;
            Speed = speed;
            Weight = weight;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Тип: {Type}, Цвет: {Color}, Скорость: {Speed} км/ч, Масса: {Weight} кг");
        }
    }

    // Класс Animal #6
    class Animal
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Sound { get; set; }

        public Animal(string type, string name, string sound)
        {
            Type = type;
            Name = name;
            Sound = sound;
        }

        public void Golos()
        {
            Console.WriteLine($"Вид: {Type}, Имя: {Name}, Голос: {Sound}");
        }
    }

    // Класс Figura #7
    class Figura
    {
        public string Name { get; set; }
        public double Base { get; set; }
        public double Height { get; set; }

        public Figura(string name, double baseLength, double height)
        {
            Name = name;
            Base = baseLength;
            Height = height;
        }

        public void ShowArea()
        {
            double area = 0;
            if (Name.ToLower() == "квадрат")
            {
                area = Base * Base;
            }
            else if (Name.ToLower() == "прямоугольник")
            {
                area = Base * Height;
            }
            Console.WriteLine($"Фигура: {Name}, Площадь: {area}");
        }
    }


    //Вывод данных классов
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Иван", "Иванов", 2, 20);
            student.ShowInfo();

            Computer computer = new Computer("Asus", 16, 512);
            computer.Info();

            Tovar tovar = new Tovar("Книга", 15.99m, true, 5);
            tovar.Kupi();

            Pogoda pogoda = new Pogoda("Минск", 18, "ясно", "север", 5);
            pogoda.Show();

            Transport transport = new Transport("Автомобиль", "Красный", 180, 1500);
            transport.ShowInfo();

            Animal animal = new Animal("Собака", "Шарик", "гав");
            animal.Golos();

            Figura figura = new Figura("Прямоугольник", 5, 10);
            figura.ShowArea();
        }
    }
}

