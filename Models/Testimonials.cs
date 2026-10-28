using System;

namespace ModernPortfolio.Models;

public class Testimonials
{
    public int Id{get;set;}
    public string ClientName {get;set;} = string.Empty;
    public string? ClientRole {get;set;} = string.Empty;
    public string ClientComment {get;set;} = string.Empty;
    public string ClientImageUrl {get;set;} = string.Empty;
    public int ClientRate {get;set;}
    public DateTime CreatedTime {get;set;}
    public bool IsActive {get;set;}
}