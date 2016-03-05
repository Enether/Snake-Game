using System.Text;

namespace SnakeGame
{
    class SnakeEvents
    {
        public void Eat(GameWindow gw)
        {
            gw.multiplierStopwatch.Stop();
            //Adds a piece to the body
            Square food = new Square();
            food.xCoord = gw.snake[gw.snake.Count - 1].xCoord;
            food.yCoord = gw.snake[gw.snake.Count - 1].yCoord;

            gw.snake.Add(food);
            GameEvents ge = new GameEvents();
            ge.GenerateFood(gw);

            // bonus multiplier for speed
            if (gw.multiplierStopwatch.ElapsedMilliseconds > 1200)
                Settings.Score += (int)(Difficulty.Points * Settings.Multiplier);
            else
                Settings.Score += (int)(Difficulty.Points * Settings.Multiplier) * 2;

            Settings.Multiplier += GameWindow.MULTIPLIER_INCREMENT;
            gw.lblScore.Text = "Score: " + Settings.Score;
            gw.lblMultiplier.Text = string.Format("Multiplier: x{0:0.00}", Settings.Multiplier);
        }
        public void MoveSnake(GameWindow gw)
        {
            for (int i = gw.snake.Count - 1; i >= 0; i--)
            {
                if (i != 0) // moves the body
                {
                    gw.snake[i].xCoord = gw.snake[i - 1].xCoord;
                    gw.snake[i].yCoord = gw.snake[i - 1].yCoord;
                }
                else // moves the head
                {
                    switch (Settings.Direction)
                    {
                        case Direction.Up:
                            gw.snake[i].yCoord--;
                            break;
                        case Direction.Down:
                            gw.snake[i].yCoord++;
                            break;
                        case Direction.Right:
                            gw.snake[i].xCoord++;
                            break;
                        case Direction.Left:
                            gw.snake[i].xCoord--;
                            break;
                    }

                    if (DetectCollision(gw) != 0) // checks if it collides
                        Die(gw, DetectCollision(gw));

                    if (AteFood(gw)) // checks if it collides with a food object
                        Eat(gw);
                }
            }
        }
        public void Die(GameWindow gw, int death)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("You died by ");
            if (death == 1)
                sb.AppendLine("going out of the world :(");
            else
                sb.AppendLine("eating your own body :(");
            sb.AppendLine("Your score was " + Settings.Score + "!");
            sb.AppendLine("Press ENTER or click the button to play again.");

            Settings.GameOver = true;
            gw.lblGameOver.Text = sb.ToString();
            gw.lblGameOver.Visible = true;
            gw.btnStartGame.Enabled = true;
            gw.btnSettings.Enabled = true;
            gw.radioBtnGroupBox.Enabled = true;
            GameEvents ge = new GameEvents();
            ge.CheckHighScore(gw); // checks if the current run was a high score and saves it in such case
            Settings.Score = 0;
        }
        public int DetectCollision(GameWindow gw)
        {
            // 0 - has not collided / 1 - has collided with borders / 2 - has collided with body
            int collided = 0;
            ushort maxXPosition = (ushort)(gw.pbCanvas.Size.Width / Settings.Width);
            ushort maxYPosition = (ushort)(gw.pbCanvas.Size.Height / Settings.Height);

            //Checks collision with game borders
            if (gw.snake[0].xCoord < 0 || gw.snake[0].yCoord < 0 || gw.snake[0].xCoord >= maxXPosition || gw.snake[0].yCoord >= maxYPosition)
                collided = 1;

            //Checks collision with body
            for (int i = 1; i < gw.snake.Count; i++)
            {
                if (gw.snake[0].xCoord == gw.snake[i].xCoord && gw.snake[0].yCoord == gw.snake[i].yCoord)
                    collided = 2;
            }

            return collided;
        }
        public bool AteFood(GameWindow gw)
        {
            bool ate = false;

            if (gw.snake[0].xCoord == gw.food.xCoord && gw.snake[0].yCoord == gw.food.yCoord)
                ate = true;

            return ate;
        }
    }
}
