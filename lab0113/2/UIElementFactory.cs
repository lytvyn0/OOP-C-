using System;

namespace DesignPatternsDemo
{
    public static class UIElementFactory
    {
        public static IUIElement CreateElement(string type)
        {
            switch (type.ToLower())
            {
                case "button":
                    return new Button();
                case "textbox":
                    return new TextBox();
                default:
                    throw new ArgumentException("Невiдомий тип елемента iнтерфейсу.");
            }
        }
    }
}
