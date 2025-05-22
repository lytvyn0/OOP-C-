using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        CharSet set1 = new CharSet(new[] { 'a', 'b', 'c' });
        CharSet set2 = new CharSet(new[] { 'c', 'd' });

        CharSet unionSet = set1 + set2; 
        CharSet extendedSet = 'e' + set1; 

        Console.WriteLine("Set1: " + set1);
        Console.WriteLine("Set2: " + set2);
        Console.WriteLine("Union: " + unionSet);
        Console.WriteLine("Extended Set1: " + extendedSet);

        Console.WriteLine("Set1 == Set2: " + (set1 == set2));
        Console.WriteLine("Set1 == Extended Set1: " + (set1 == extendedSet));
    }
}
