  /* Задача 1. Вивести таблицю квадратів чисел від 1 до 10.

 

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Число\tКвадрат");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i}\t {i * i}");
        }
    }
}

*/




/* Задача 2. Обчислити суму цифр у введеному числі.
 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введiть число:");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        Console.WriteLine("Сума цифр: " + sum);
    }
}
*/
 


/* Задача 3. Визначити кількість додатних чисел у масиві.
  
  
 
using System;

class Program
{
    static void Main()
    {
       
        int[] numbers = { 1, -2, 3, 4, -5, 6, -7 };

        int count = 0;

       
        foreach (int number in numbers)
        {
           
            if (number > 0)
            {
                count++;
            }
        }

        
        Console.WriteLine("Кiлькiсть додатнiх чисел у масивi: " + count);
    }
}

 */