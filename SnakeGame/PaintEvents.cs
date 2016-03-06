using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    class PaintEvents
    {
        public void PaintLightBlue(PaintEventArgs e, GameWindow gw)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                Brush snakeColor;

                //Draw Snake piece by piece
                for (int i = 0; i < gw.snake.Count; i++)
                {
                    if (i == 0)
                        snakeColor = Brushes.Black; // color of the head
                    else
                        snakeColor = Brushes.DarkGreen; // color of the body

                    // Draw Snake Piece
                    canvas.FillRectangle(snakeColor, new Rectangle(
                        gw.snake[i].xCoord * Settings.Width,
                        gw.snake[i].yCoord * Settings.Height,
                        Settings.Width, Settings.Height));
                }

                // Draw Food
                canvas.FillEllipse(Brushes.Red, new Rectangle(
                    gw.food.xCoord * Settings.Width,
                    gw.food.yCoord * Settings.Height,
                    Settings.Width, Settings.Height));
            }
        }
        public void PaintBlack(PaintEventArgs e, GameWindow gw)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                Brush snakeColor;

                //Draw Snake piece by piece
                for (int i = 0; i < gw.snake.Count; i++)
                {
                    if (i == 0)
                        snakeColor = Brushes.LawnGreen; // color of the head
                    else
                        snakeColor = Brushes.DarkGreen; // color of the body

                    // Draw Snake Piece
                    canvas.FillRectangle(snakeColor, new Rectangle(
                        gw.snake[i].xCoord * Settings.Width,
                        gw.snake[i].yCoord * Settings.Height,
                        Settings.Width, Settings.Height));
                }

                // Draw Food
                canvas.FillEllipse(Brushes.Red, new Rectangle(
                    gw.food.xCoord * Settings.Width,
                    gw.food.yCoord * Settings.Height,
                    Settings.Width, Settings.Height));
            }
        }
        public void PaintIndigo(PaintEventArgs e, GameWindow gw)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                Brush snakeColor;

                //Draw Snake piece by piece
                for (int i = 0; i < gw.snake.Count; i++)
                {
                    if (i == 0)
                        snakeColor = Brushes.LawnGreen; // color of the head
                    else
                        snakeColor = Brushes.Green; // color of the body

                    // Draw Snake Piece
                    canvas.FillRectangle(snakeColor, new Rectangle(
                        gw.snake[i].xCoord * Settings.Width,
                        gw.snake[i].yCoord * Settings.Height,
                        Settings.Width, Settings.Height));
                }

                // Draw Food
                canvas.FillEllipse(Brushes.LightYellow, new Rectangle(
                    gw.food.xCoord * Settings.Width,
                    gw.food.yCoord * Settings.Height,
                    Settings.Width, Settings.Height));
            }
        }
    }
}
