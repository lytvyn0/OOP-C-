// 1. Створіть клас Book з властивостями Title, Author та Price. Реалізуйте конструктор,
// що ініціалізує всі ці властивості, і використайте ініціалізатор в методі Main.
/* 
using System;

namespace BookApp
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
        
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Price: {Price:145 UAH}");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Book myBook = new Book("The Great Gatsby", "F. Scott Fitzgerald", 145);
            
            myBook.DisplayBookInfo();

            Console.ReadLine();
        }
    }
}

*/
// 2. Створіть клас Student з полем Name. Створіть метод, який приймає студентів за
// посиланням і змінює їхні імена
/*
using System;
using System.Collections.Generic;

namespace StudentApp
{
    public class Student
    {
        public string Name;
        
        public Student(string name)
        {
            Name = name;
        }
    }

    class Program
    {
        static void ChangeNames(List<Student> students)
        {
            foreach (Student student in students)
            {
                student.Name = "NewName"; 
            }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

           
            students.Add(new Student("Vlad"));
            students.Add(new Student("Vasyl"));
            students.Add(new Student("Dmytro"));
            
            Console.WriteLine("До змiни iмен:");
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
            
            ChangeNames(students);
            Console.WriteLine("\nПiсля змiни iмен:");
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }

            Console.ReadLine();
        }
    }
}

*/ 
// 3. Використовуйте псевдонім для типу DateTime і створіть змінну, яка зберігає
// поточну дату та час.

using System;

namespace DateTimeApp
{
    using MyDateTime = System.DateTime;
    class Program
    {
        static void Main(string[] args)
        {
            MyDateTime currentDateTime = MyDateTime.Now;
            Console.WriteLine("Поточна дата та час: " + currentDateTime);
            Console.ReadLine();
        }
    }
}


