namespace recipeApp.Models
{
    public class WeekPlan
    {
        public int WeekPlanId { get; set; }
        public DayPlan Monday { get; set; }
        public DayPlan Tuesday { get; set; }
        public DayPlan Wednesday { get; set; }
        public DayPlan Thursday { get; set; }
        public DayPlan Friday { get; set; }
        public DayPlan Saturday { get; set; }
        public DayPlan Sunday { get; set; }

    }
}