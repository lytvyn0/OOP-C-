using System;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Factory: Створення елементiв iнтерфейсу ===");

            IUIElement button = UIElementFactory.CreateElement("button");
            IUIElement textBox = UIElementFactory.CreateElement("textbox");

            button.Render();     
            textBox.Render();   

            Console.ReadLine(); 
        }
    }
}
