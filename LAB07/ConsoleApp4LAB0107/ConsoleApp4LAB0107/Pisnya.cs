using System;

public class Pisnya : MuzychniyTvir
{
    public string Tekst { get; set; }
    public string AvtorTekstu { get; set; }

    public Pisnya(string nazva, double tryvalist, string tekst, string avtorTekstu)
        : base(nazva, tryvalist)
    {
        Tekst = tekst;
        AvtorTekstu = avtorTekstu;
    }

    public override void SformuvatyOpis()
    {
        try
        {
            if (Tryvalist <= 0)
                throw new TryvalistException("Тривалiсть піснi повинна бути бiльшою за 0.");
            Console.WriteLine($"Пiсня: {Nazva}, Автор тексту: {AvtorTekstu}, Тривалiсть: {Tryvalist} хв.");
        }
        catch (TryvalistException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}
