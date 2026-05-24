using Menu.Classes;

using static Menu.Main;
using static Menu.Settings;

namespace Menu
{
    public class Buttons
    {
        /*
         * Here is where all of your buttons are located.
         * To create a button, you may use the following code:
         * 
         * Move to Category:
         *   new ButtonInfo { buttonText = "Settings", method =() => currentCategory = 1, isTogglable = false, toolTip = "Opens the main settings page for the menu."},
         *   new ButtonInfo { buttonText = "Return to Main", method =() => currentCategory = 0, isTogglable = false, toolTip = "Returns to the main page of the menu."},
         * 
         * Togglable Mod:
         *   new ButtonInfo { buttonText = "Platforms", method =() => Movement.Platforms(), toolTip = "Spawns platforms on your hands when pressing grip."},
         */

        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods [0]
                new ButtonInfo { buttonText = "Rain", method =() => SkyAndTime.Rain(), isTogglable = false },
                new ButtonInfo { buttonText = "No Rain", method =() => SkyAndTime.NoRain(), isTogglable = false },
                new ButtonInfo { buttonText = "Day", method =() => SkyAndTime.DayTime(), isTogglable = false },
                new ButtonInfo { buttonText = "Morning", method =() => SkyAndTime.MorningTime(), isTogglable = false },
                new ButtonInfo { buttonText = "Evening", method =() => SkyAndTime.EveningTime(), isTogglable = false },
                new ButtonInfo { buttonText = "Chocolate Sky", method =() => SkyAndTime.ChocolateSky(), isTogglable = false },
                new ButtonInfo { buttonText = "White Sky", method =() => SkyAndTime.CumSky(), isTogglable = false },
                new ButtonInfo { buttonText = "Yellow Sky", method =() => SkyAndTime.PissSky(), isTogglable = false },
                new ButtonInfo { buttonText = "Nostalgic Sky", method =() => SkyAndTime.NostalgiaSky(), isTogglable = false },
                new ButtonInfo { buttonText = "Blue Sky", method =() => SkyAndTime.blueSky(), isTogglable = false },
                new ButtonInfo { buttonText = "Coral Sky", method =() => SkyAndTime.CoralSky(), isTogglable = false },
                new ButtonInfo { buttonText = "Green Sky", method =() => SkyAndTime.greenSky(), isTogglable = false },
                new ButtonInfo { buttonText = "Purple Sky", method =() => SkyAndTime.PurpleSky(), isTogglable = false },
                new ButtonInfo { buttonText = "Red Sky", method =() => SkyAndTime.redSky(), isTogglable = false },
                new ButtonInfo { buttonText = "Golden Sky", method =() => SkyAndTime.GoldenSky(), isTogglable = false },
                new ButtonInfo { buttonText = "Light Pink Sky", method =() => SkyAndTime.LightPinkSky(), isTogglable = false },
                new ButtonInfo { buttonText = "Cornflower Blue Sky", method =() => SkyAndTime.CornflowerBlueSky(), isTogglable = false },
                new ButtonInfo { buttonText = "Powder Blue Sky", method =() => SkyAndTime.PowderBlueSky(), isTogglable = false },
                new ButtonInfo { buttonText = "Tan Sky", method =() => SkyAndTime.TanSky(), isTogglable = false },
            },
        };
    }
}
