using System;

public class InstrumentalniyTvir : MuzychniyTvir
{
    public string Instrumenty { get; set; }

    public InstrumentalniyTvir(string nazva, double tryvalist, string instrumenty)
        : base(nazva, tryvalist)
    {
        Instrumenty = instrumenty;
    }

    public override void SformuvatyOpis()
    {
        try
        {
            if (Tryvalist <= 0)
                throw new TryvalistException("Тривалiсть iнструментального твору повинна бути бiльшою за 0.");
            Console.WriteLine($"Iнструментальний твiр: {Nazva}, Iнструменти: {Instrumenty}, Тривалiсть: {Tryvalist} хв.");
        }
        catch (TryvalistException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}
