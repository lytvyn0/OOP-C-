using System;

public class MuzychniyTvir
{
    private string _nazva;

    public string Nazva
    {
        get => _nazva;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new NazvaException("Назва не може бути порожньою.");
            _nazva = value;
        }
    }

    public double Tryvalist { get; set; }

    public MuzychniyTvir(string nazva, double tryvalist)
    {
        Nazva = nazva;
        Tryvalist = tryvalist;
    }

    public virtual void SformuvatyOpis()
    {
        try
        {
            if (Tryvalist <= 0)
                throw new TryvalistException("Тривалiсть твору повинна бути бiльшою за 0.");
            Console.WriteLine($"Музичний твiр: {Nazva}, Тривалiсть: {Tryvalist} хв.");
        }
        catch (TryvalistException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Iнша помилка: {ex.Message}");
        }
    }
}
