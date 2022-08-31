using Microsoft.AspNetCore.Mvc;

namespace DSLabWeek01.Models;

public class Toy
{
    public int Id { get; set; }
    public string Brand { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
}
