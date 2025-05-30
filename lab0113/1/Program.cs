using System;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Singleton: Налаштування програми ===");

            AppSettings settings = AppSettings.Instance;

            Console.WriteLine("Мова за замовчуванням: " + settings.Language);
            Console.WriteLine("Темна тема увiмкнена: " + settings.DarkModeEnabled);


            settings.Language = "en-US";
            settings.DarkModeEnabled = true;

            Console.WriteLine("\n=== Оновленi налаштування ===");
            Console.WriteLine("Мова: " + settings.Language);
            Console.WriteLine("Темна тема увiмкнена: " + settings.DarkModeEnabled);

            var anotherReference = AppSettings.Instance;
            Console.WriteLine("\n=== Перевiрка Singleton ===");
            Console.WriteLine("Мова (через iншу змiнну): " + anotherReference.Language);

            Console.ReadLine(); 
        }
    }
}
