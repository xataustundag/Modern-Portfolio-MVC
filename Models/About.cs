using System;

namespace ModernPortfolio.Models;

public class About
{
    public int Id { get; set; } // PostgreSQL kullanacagimiz icin auto increment yapiyor.
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? ImageUrl {get; set;}
    public DateTime CreateTime {get;set;}
    public DateTime? EditTime {get;set;}
}