namespace MealPlanner.Api.Models;
public class InventoryItem
{
    public Guid Id { get; set; }
    public Guid IngredientId { get; set; }
    public bool IsAvailable { get; set; }   // TRUE = you have it, FALSE = you don’t.
}
