// Створити об'єкт класу Зоряна система, використовуючи класи Планета, Зірка, Місяць.
// Методи: вивести на консоль кількість планет в зоряній системі, назва зірки, додавання планети в систему.
/*

using System;
using System.Collections.Generic;

namespace StarSystemApp
{
   
    public class Star
    {
        public string Name { get; set; }

        public Star(string name)
        {
            Name = name;
        }
    }

   
    public class Moon
    {
        public string Name { get; set; }

        public Moon(string name)
        {
            Name = name;
        }
    }

   
    public class Planet
    {
        public string Name { get; set; }
        public List<Moon> Moons { get; set; }

        public Planet(string name)
        {
            Name = name;
            Moons = new List<Moon>();
        }

        public void AddMoon(Moon moon)
        {
            Moons.Add(moon);
        }

        public void PrintMoonCount()
        {
            Console.WriteLine($"Планета {Name} має {Moons.Count} супутникiв.");
        }
    }


    public class StarSystem
    {
        public Star CentralStar { get; set; }
        public List<Planet> Planets { get; set; }

        public StarSystem(Star star)
        {
            CentralStar = star;
            Planets = new List<Planet>();
        }

        public void AddPlanet(Planet planet)
        {
            Planets.Add(planet);
        }

        public void PrintPlanetCount()
        {
            Console.WriteLine($"Кiлькiсть планет у зорянiй системi: {Planets.Count}");
        }

        public void PrintStarName()
        {
            Console.WriteLine($"Назва зiрки: {CentralStar.Name}");
        }

        public void PrintPlanetsAndMoons()
        {
            foreach (var planet in Planets)
            {
                Console.WriteLine($"Планета: {planet.Name}, Кiлькiсть супутникiв: {planet.Moons.Count}");
                foreach (var moon in planet.Moons)
                {
                    Console.WriteLine($"  - {moon.Name}");
                }
            }
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
      
            Star sun = new Star("Сонце");

            StarSystem solarSystem = new StarSystem(sun);

          
            Planet earth = new Planet("Земля");
            Planet mars = new Planet("Марс");

         
            earth.AddMoon(new Moon("Мiсяць"));
            mars.AddMoon(new Moon("Фобос"));
            mars.AddMoon(new Moon("Деймос"));

        
            solarSystem.AddPlanet(earth);
            solarSystem.AddPlanet(mars);

           
            solarSystem.PrintStarName();
            solarSystem.PrintPlanetCount();
            solarSystem.PrintPlanetsAndMoons();

            Console.ReadLine(); 
        }
    }
}
*/
// 6.	Створити клас TMatrix, який представляє матрицю і містить методи для обчислення детермінанта та суми елементів матриці.
// На основі цього класу створити класи, які представляють квадратні матриці порядку 2, та порядку 3.
// За допомогою цих класів обчислити вираз 
/*
using System;

class TMatrix
{
    protected double[,] matrix;
    protected int size;

    public TMatrix(int size)
    {
        this.size = size;
        matrix = new double[size, size];
    }

    public void InputMatrix()
    {
        Console.WriteLine($"Введiть елементи матрицi {size}x{size}:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"[{i + 1},{j + 1}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }
    }

    public double SumElements()
    {
        double sum = 0;
        foreach (var val in matrix)
            sum += val;
        return sum;
    }

    public virtual double Determinant()
    {
        throw new NotImplementedException("Детермiнант реалiзується в похiдному класi.");
    }
}

class Matrix2x2 : TMatrix
{
    public Matrix2x2() : base(2) { }

    public override double Determinant()
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }
}

class Matrix3x3 : TMatrix
{
    public Matrix3x3() : base(3) { }

    public override double Determinant()
    {
        return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
             - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
             + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Matrix3x3 A = new Matrix3x3();
        A.InputMatrix();

        Matrix2x2 B = new Matrix2x2();
        B.InputMatrix();

        double sumA = A.SumElements();

        
        double detA = A.Determinant();
        double detB = B.Determinant();

        double S = sumA + Math.Abs(4 + Math.Abs(detB));

        Console.WriteLine($"\nДетермiнант A: {detA}");
        Console.WriteLine($"Детермiнант B: {detB}");
        Console.WriteLine($"Сума елементiв A: {sumA}");
        Console.WriteLine($"Результат виразу S: {S}");
    }
}
*/