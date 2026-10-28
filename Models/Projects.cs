using System;

namespace ModernPortfolio.Models;

public class Projects
{
    // This entity is where we show our projects in portfolio page.
    
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ProjectUrl {get;set;} = string.Empty;
    public string GitHubUrl {get;set;} = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public DateTime CreatedTime{get;set;}
    public bool IsActive {get;set;} // Belki proje o an acik degilse deactive edebilelim diye.
}