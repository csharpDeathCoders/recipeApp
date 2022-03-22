using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeApp.Models
{
    public class WeekPlan
    {
        public int WeekPlanId { get; set; }
        [ForeignKey("IdentityUser")]
        public string UserId { get; set; }
        [NotMapped]
        public DayPlan? Monday { get; set; }
        [NotMapped]
        public DayPlan? Tuesday { get; set; }
        [NotMapped]
        public DayPlan? Wednesday { get; set; }
        [NotMapped]
        public DayPlan? Thursday { get; set; }
        [NotMapped]
        public DayPlan? Friday { get; set; }
        [NotMapped]
        public DayPlan? Saturday { get; set; }
        [NotMapped]
        public DayPlan? Sunday { get; set; }

    }
}