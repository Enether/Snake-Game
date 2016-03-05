
namespace SnakeGame
{
    class Difficulty
    {
        public static ushort Points { get; set; }
        public static ushort GameSpeed { get; set; }
        public Difficulty(ushort points, ushort gamespeed)
        {
            Points = points;
            GameSpeed = gamespeed;
        }
    }
}
