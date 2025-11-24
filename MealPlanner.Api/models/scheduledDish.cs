namespace MealPlanner.Api.Models;
public class ScheduledDish
{
    public Guid Id { get; set; }                // PK

    public Guid DishId { get; set; }            // FK → Dish.Id

    public DateOnly Date { get; set; }          // When you will eat it
    public TimeOnly PrepStartTime { get; set; } // When prep should begin
}
