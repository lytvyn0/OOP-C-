using System;
using System.Collections.Generic;

public class Albom
{
    public string Avtor { get; set; }  
    public string Zhanr { get; set; }  
    public int RikVypusku { get; set; }  
    public double ZagalnaTryvalist { get; set; }  

   
    public List<MuzychniyTvir> Tvory { get; set; } = new List<MuzychniyTvir>();

    public void SformuvatyOpis()
    {
        Console.WriteLine($"Альбом: {Avtor} - {Zhanr}, Рiк випуску: {RikVypusku}, Загальна тривалiсть: {ZagalnaTryvalist} хв.");
        foreach (var tvor in Tvory)
        {
            tvor.SformuvatyOpis(); 
        }
    }
}
