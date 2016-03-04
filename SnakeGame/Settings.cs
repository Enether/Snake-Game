

namespace SnakeGame
{
    public enum Direction { Up, Down, Left, Right };
    public enum BackgroundColor { LightBlue,  Black, Indigo, DarkKhaki};
    class Settings
    {
        public static double Multiplier { get; set; }
        public static ushort Width { get; set; }
        public static ushort Height { get; set; }

        public static int Score { get; set; }

        public static bool GameOver { get; set; }
        public static Direction Direction { get; set; }
        public static BackgroundColor BackgroundColor { get; set; }

        public Settings()
        {
            Width = 16;
            Height = 16;
            Score = 0;
            Multiplier = 1.00;
            GameOver = false;
            Direction = Direction.Right;           
        }
    }
}
