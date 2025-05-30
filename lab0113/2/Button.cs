using System;

namespace DesignPatternsDemo
{
    public class Button : IUIElement
    {
        public void Render()
        {
            Console.WriteLine("Кнопка вiдображена.");
        }
    }
}
