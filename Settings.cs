using Menu.Classes;
using UnityEngine;

namespace Menu
{
    public class Settings
    {
    

        public static ExtGradient backgroundColor = new ExtGradient {colors = ExtGradient.GetSolidGradient(Color.black)};
        public static ExtGradient[] buttonColors = new ExtGradient[]
        {
            new ExtGradient { colors = ExtGradient.GetSolidGradient(Color.gray1) }, // Disabled
            new ExtGradient { rainbow = false } // Enabled
        };
        public static Color[] textColors = new Color[]
        {
            Color.white,
            Color.white 
        };

        public static Font currentFont = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;

        public static bool fpsCounter = false;
        public static bool disconnectButton = false;
        public static bool rightHanded;
        public static bool disableNotifications;

        public static KeyCode keyboardButton = KeyCode.Q;

        public static Vector3 menuSize = new Vector3(0.1f, 1f, 1.1f); 
        public static int buttonsPerPage = 5;

        public static float gradientSpeed = 0.5f; 
    }
}
