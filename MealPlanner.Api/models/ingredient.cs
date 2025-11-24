namespace MealPlanner.Api.Models;

public class Ingredient
{
    public Guid id {get; set; }
    public string Name {get; set;} = null!;
    public string? Unit {get; set;}
    
}