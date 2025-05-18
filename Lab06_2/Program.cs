using System;
using System.Collections.Generic;
using System.Linq;

public class CollectionType
{
    public string Name { get; set; }
    public double Value { get; set; }

    public CollectionType(string name, double value)
    {
        Name = name;
        Value = value;
    }

    public override string ToString()
    {
        return $"{Name} (Value: {Value})";
    }
}

class Program
{
    static void Main()
    {

        List<CollectionType> collections = new List<CollectionType>
        {
            new CollectionType("Collection A", 150.0),
            new CollectionType("Collection B", 320.5),
            new CollectionType("Collection C", 75.25),
            new CollectionType("Collection D", 500.0),
            new CollectionType("Collection E", 210.0)
        };

        double threshold = 200.0;

        int countAboveThreshold = collections.Count(c => c.Value > threshold);
        Console.WriteLine($"Кількість колекцій зі значенням більше {threshold}: {countAboveThreshold}");

        CollectionType maxCollection = collections.OrderByDescending(c => c.Value).First();
        Console.WriteLine($"Максимальна колекція: {maxCollection}");

        CollectionType minCollection = collections.OrderBy(c => c.Value).First();
        Console.WriteLine($"Мінімальна колекція: {minCollection}");
    }
}
