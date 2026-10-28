using System;

namespace ModernPortfolio.Models;

public class Skills()
{
    // Burada Orjinal website dokumanindaki Skill numaralandirma tablosunu yaratiyoruz.
    public int Id {get;set;}
    public string name {get;set;} = string.Empty;
    public int Percentage {get;set;}
    public int DisplayOrder {get;set;}
    public DateTime CreateTime {get;set;}
}