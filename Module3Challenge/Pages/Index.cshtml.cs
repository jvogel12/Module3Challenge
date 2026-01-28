using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module3Challenge.Pages
{
    public class IndexModel : PageModel
    {
        // Bound form values
        [BindProperty]
        public int HungerLevel { get; set; }

        [BindProperty]
        public int DayOfWeek { get; set; }

        // Output messages
        public string HungerMessage { get; set; } = string.Empty;
        public string SoundMessage { get; set; } = string.Empty;
        public string DayMessage { get; set; } = string.Empty;

        public void OnPost()
        {
            // If-else statement
            if (HungerLevel >= 8)
            {
                HungerMessage = "Lion: Roar! I need a big meal!";
            }
            else if (HungerLevel >= 5)
            {
                HungerMessage = "Monkey: Ooh ooh! I'll take some bananas.";
            }
            else
            {
                HungerMessage = "Tortoise: Slow and steady—I'll have some lettuce.";
            }

            // Ternary operator
            SoundMessage = HungerLevel >= 8
                ? "Listen to the Lion: Roar!"
                : "Listen to the Monkey: Ooh ooh!";

            // Switch statement
            switch (DayOfWeek)
            {
                case 1:
                    DayMessage = "Sunday: Family Day at the Zoo!";
                    break;
                case 2:
                    DayMessage = "Monday: Monkey Mischief Show!";
                    break;
                case 3:
                    DayMessage = "Tuesday: Tortoise Talk!";
                    break;
                case 4:
                    DayMessage = "Wednesday: Wildlife Education Day!";
                    break;
                case 5:
                    DayMessage = "Thursday: Big Cat Feeding Time!";
                    break;
                case 6:
                    DayMessage = "Friday: Zoo Keeper Q&A!";
                    break;
                case 7:
                    DayMessage = "Saturday: Safari Adventure!";
                    break;
                default:
                    DayMessage = "Invalid day selected.";
                    break;
            }
        }
    }
}