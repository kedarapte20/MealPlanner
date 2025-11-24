namespace MealPlanner.Api.Models;

public class DishIngredient
{
    public Guid Id { get; set; }                // PK, can also be composite PK if preferred

    public Guid DishId { get; set; }            // FK → Dish

    public Guid IngredientId { get; set; }      // FK → Ingredient

    public decimal QuantityRequired { get; set; }
}