using System.Collections.Generic;

public class Kolektsiya
{
    public string Nazva { get; set; }
    public string PIBVlasnyka { get; set; }

    public List<Albom> Albomy { get; set; } = new List<Albom>();
}
