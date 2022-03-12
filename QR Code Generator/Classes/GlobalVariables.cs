using System.Drawing;

namespace QR_Code_Generator.Classes
{
    public static class GlobalVariables
    {
        public static string CurrentContentPanel { get; set; }
        public static string CurrentFunctionPanel { get; set; }
        public static int PixelsPerModule { get; set; }
        public static bool AllDayEvent { get; set; }
        public static Color QRCodeColor { get; set; } = Color.Black;
        public static Bitmap QRCodeIcon { get; set; }
        public static int ReadTypeFlag { get; set; } = 0;
        public static string QRCodeImagePath { get; set; }
        public static Bitmap QRCodeImage { get; set; }
    }
}
