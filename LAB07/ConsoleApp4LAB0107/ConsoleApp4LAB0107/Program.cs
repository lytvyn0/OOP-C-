using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Вiтаємо у програмi для створення музичних творiв!");

        
        var kolektsiya = new Kolektsiya
        {
            Nazva = "Моя музична колекцiя",
            PIBVlasnyka = "Iван Iванов"
        };

        bool continueAdding = true;

        while (continueAdding)
        {
            Console.WriteLine("\nОберiть дiю:");
            Console.WriteLine("1. Додати альбом");
            Console.WriteLine("2. Додати пiсню");
            Console.WriteLine("3. Додати iнструментальний твiр");
            Console.WriteLine("0. Вихiд");
            Console.Write("Ваш вибiр: ");
            string choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        AddAlbom(kolektsiya);
                        break;

                    case "2":
                        AddPisnya();
                        break;

                    case "3":
                        AddInstrumentalniyTvir();
                        break;

                    case "0":
                        continueAdding = false;
                        break;

                    default:
                        Console.WriteLine("Невiрний вибiр, спробуйте ще раз.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка: {ex.Message}");
            }
        }

        Console.WriteLine("\nПрограма завершила роботу.");
    }

    static void AddAlbom(Kolektsiya kolektsiya)
    {
        Console.Write("\nВведiть автор/групу альбому: ");
        string avtor = Console.ReadLine();

        Console.Write("Введiть жанр альбому: ");
        string zhanr = Console.ReadLine();

        Console.Write("Введiть рiк випуску альбому: ");
        int rikVypusku = int.Parse(Console.ReadLine());

        Console.Write("Введiть загальну тривалiсть звучання альбому (в хвилинах): ");
        double zagalnaTryvalist = double.Parse(Console.ReadLine());

        var albom = new Albom
        {
            Avtor = avtor,
            Zhanr = zhanr,
            RikVypusku = rikVypusku,
            ZagalnaTryvalist = zagalnaTryvalist
        };

        bool addMore = true;
        while (addMore)
        {
            Console.WriteLine("\nОберiть тип музичного твору для додавання до альбому:");
            Console.WriteLine("1. Пiсня");
            Console.WriteLine("2. Iнструментальний твiр");
            Console.WriteLine("0. Завершити додавання творiв до альбому");
            Console.Write("Ваш вибiр: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddPisnyaToAlbom(albom);
                    break;

                case "2":
                    AddInstrumentalniyTvirToAlbom(albom);
                    break;

                case "0":
                    addMore = false;
                    break;

                default:
                    Console.WriteLine("Невiрний вибiр, спробуйте ще раз.");
                    break;
            }
        }

        kolektsiya.Albomy.Add(albom);
        albom.SformuvatyOpis();  
    }

    static void AddPisnyaToAlbom(Albom albom)
    {
        Console.Write("\nВведiть назву пiснi: ");
        string nazva = Console.ReadLine();

        Console.Write("Введiть тривалiсть пiснi (в хвилинах): ");
        double tryvalist = double.Parse(Console.ReadLine());

        Console.Write("Введiть текст пiснi: ");
        string tekst = Console.ReadLine();

        Console.Write("Введiть автора тексту: ");
        string avtorTekstu = Console.ReadLine();

        try
        {
            var pisnya = new Pisnya(nazva, tryvalist, tekst, avtorTekstu);
            albom.Tvory.Add(pisnya);
            Console.WriteLine("Пiсня успiшно додана до альбому.");
        }
        catch (TryvalistException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
        catch (NazvaException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }

    static void AddInstrumentalniyTvirToAlbom(Albom albom)
    {
        Console.Write("\nВведiть назву iнструментального твору: ");
        string nazva = Console.ReadLine();

        Console.Write("Введiть тривалiсть твору (в хвилинах): ");
        double tryvalist = double.Parse(Console.ReadLine());

        Console.Write("Введiть iнструменти (через кому): ");
        string instrumenty = Console.ReadLine();

        try
        {
            var instrumentalniyTvir = new InstrumentalniyTvir(nazva, tryvalist, instrumenty);
            albom.Tvory.Add(instrumentalniyTvir);
            Console.WriteLine("Iнструментальний твiр успiшно доданий до альбому.");
        }
        catch (TryvalistException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
        catch (NazvaException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }

    static void AddPisnya()
    {
        Console.Write("\nВведiть назву пiснi: ");
        string nazva = Console.ReadLine();

        Console.Write("Введiть тривалiсть пiснi (в хвилинах): ");
        double tryvalist = double.Parse(Console.ReadLine());

        Console.Write("Введiть текст пiснi: ");
        string tekst = Console.ReadLine();

        Console.Write("Введiть автора тексту: ");
        string avtorTekstu = Console.ReadLine();

        try
        {
            var pisnya = new Pisnya(nazva, tryvalist, tekst, avtorTekstu);
            pisnya.SformuvatyOpis();
        }
        catch (TryvalistException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
        catch (NazvaException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }

    static void AddInstrumentalniyTvir()
    {
        Console.Write("\nВведiть назву iнструментального твору: ");
        string nazva = Console.ReadLine();

        Console.Write("Введiть тривалiсть твору (в хвилинах): ");
        double tryvalist = double.Parse(Console.ReadLine());

        Console.Write("Введiть iнструменти (через кому): ");
        string instrumenty = Console.ReadLine();

        try
        {
            var instrumentalniyTvir = new InstrumentalniyTvir(nazva, tryvalist, instrumenty);
            instrumentalniyTvir.SformuvatyOpis();
        }
        catch (TryvalistException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
        catch (NazvaException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}
