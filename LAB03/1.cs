//Задача 1. Базові класи і наслідування.
//Реалізуйте класи Employee із похідними Manager і Engineer.

/*
using System;

namespace InheritanceExample
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual string GetInfo()
        {
            return $"Employee: {Name}, Salary: {Salary}";
        }

        public virtual string Work()
        {
            return $"{Name} is working.";
        }
    }

    public class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(string name, decimal salary, string department)
            : base(name, salary)
        {
            Department = department;
        }

        public override string GetInfo()
        {
            return $"Manager: {Name}, Salary: {Salary}, Department: {Department}";
        }

        public override string Work()
        {
            return $"{Name} is managing the {Department} department.";
        }
    }

    public class Engineer : Employee
    {
        public string Specialty { get; set; }

        public Engineer(string name, decimal salary, string specialty)
            : base(name, salary)
        {
            Specialty = specialty;
        }

        public override string GetInfo()
        {
            return $"Engineer: {Name}, Salary: {Salary}, Specialty: {Specialty}";
        }

        public override string Work()
        {
            return $"{Name} is working on {Specialty} projects.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Ivan", 30000);
            Manager mgr = new Manager("Olena", 50000, "HR");
            Engineer eng = new Engineer("Petro", 40000, "Software");

            Employee[] employees = { emp, mgr, eng };

            foreach (var e in employees)
            {
                Console.WriteLine(e.GetInfo());
                Console.WriteLine(e.Work());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
*/



// Задача 2. Сховування методів.
//Реалізуйте базовий метод Calculate(), який у похідному класі приховується за
//допомогою ключового слова new.
/*
using System;


    public class Calculator
    {
        public virtual void Calculate()
        {
            Console.WriteLine("Базова логiка обчислення.");
        }
    }


    public class AdvancedCalculator : Calculator
    {
        public new void Calculate()
        {
            Console.WriteLine("Розширена логiка обчислення.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator baseCalc = new Calculator();
            AdvancedCalculator advCalc = new AdvancedCalculator();
            Calculator hiddenCalc = new AdvancedCalculator();

            Console.WriteLine("Виклик через об'єкт базового класу:");
            baseCalc.Calculate();

            Console.WriteLine("Виклик через об'єкт похiдного класу:");
            advCalc.Calculate();

            Console.WriteLine("Виклик через змiнну базового типу:");
            hiddenCalc.Calculate();

            Console.ReadLine();
        }
    }
*/






//Задача 3. Узагальнені методи.
// Реалізуйте метод ReverseArray<T>(), який перевертає масив.
/*
using System;

    class Program
    {

        public static void ReverseArray<T>(T[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {

                T temp = array[left];
                array[left] = array[right];
                array[right] = temp;

                left++;
                right--;
            }
        }


        public static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            string[] words = { "один", "два", "три" };

            Console.WriteLine("Початковий масив чисел:");
            PrintArray(numbers);

            ReverseArray(numbers);

            Console.WriteLine("Перевернутий масив чисел:");
            PrintArray(numbers);

            Console.WriteLine("\nПочатковий масив слiв:");
            PrintArray(words);

            ReverseArray(words);

            Console.WriteLine("Перевернутий масив слiв:");
            PrintArray(words);

            Console.ReadLine();
        }
    }

*/