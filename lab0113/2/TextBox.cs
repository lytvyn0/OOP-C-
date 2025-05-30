using System;

namespace DesignPatternsDemo
{
    public class TextBox : IUIElement
    {
        public void Render()
        {
            Console.WriteLine("Поле введення вiдображено.");
        }
    }
}
