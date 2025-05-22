// 1)
/*
 using System;

class Program
{
    static void Main()
    {
        Console.Write("Введiть рядок (тiльки 0 i 1): ");
        string input = Console.ReadLine();

        Console.Write("З якоi позицii почати замiну (0 - перший символ): ");
        int start = int.Parse(Console.ReadLine());

        char[] chars = input.ToCharArray();

        for (int i = start; i < chars.Length; i++)
        {
            if (chars[i] == '0') chars[i] = '1';
            else if (chars[i] == '1') chars[i] = '0';
        }

        string result = new string(chars);
        Console.WriteLine("Результат: " + result);
    }
}

*/

// 2)
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введiть цiльову дату (рррр-мм-дд): ");
        DateTime targetDate = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Today;

        if (targetDate < today)
        {
            Console.WriteLine("Ця дата вже була.");
        }
        else
        {
            int days = (targetDate - today).Days;
            Console.WriteLine($"До вказаної дати залишилося {days} днiв.");
        }
    }
}

*/

// 3)
/*
using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введiть три дати у форматi дд.мм.рррр, роздiленi комами: ");
        string input = Console.ReadLine();

        string[] parts = input.Split(',');

        DateTime[] dates = parts.Select(p => DateTime.ParseExact(p.Trim(), "dd.MM.yyyy", CultureInfo.InvariantCulture)).ToArray();

        int minYear = dates.Min(d => d.Year);
        Console.WriteLine("Рiк з найменшим номером: " + minYear);

        Console.WriteLine("Веснянi дати:");
        foreach (var date in dates)
        {
            if (date.Month >= 3 && date.Month <= 5)
                Console.WriteLine(date.ToShortDateString());
        }

        DateTime latest = dates.Max();
        Console.WriteLine("Найпiзнiша дата: " + latest.ToShortDateString());
    }
}
*/