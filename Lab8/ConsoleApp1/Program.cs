using System;
using System.IO;

class Program
{
    static void Main()
    {
        string f1 = "f1.txt";
        string f2 = "f2.txt";
        string h = "h.txt";

        try
        {

            File.Copy(f1, h, true);
            File.Copy(f2, f1, true);
            File.Copy(h, f2, true);

            Console.WriteLine("Файли успiшно обмiнянi.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Сталася помилка: " + ex.Message);
        }
    }
}
