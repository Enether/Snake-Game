using System;
using System.Windows.Forms;

namespace SnakeGame
{
    class GameEvents
    {
        public void InitializeGame(GameWindow gw)
        {
            gw.backgroundSoundtrack.PlayLooping();
            //set settings to default
            new Settings();
            new Difficulty(100, 16);
            new ScoreReader();
            gw.lblScore.Text = "Score: " + Settings.Score;
            gw.lblEasyHighScore.Text = "Easy: " + ScoreReader.ReadScore()["easyScore"];
            gw.lblMediumHighScore.Text = "Medium: " + ScoreReader.ReadScore()["mediumScore"];
            gw.lblHardHighScore.Text = "Hard: " + ScoreReader.ReadScore()["hardScore"];
            gw.lblHighestScore.Text = "Highest Score: " + Math.Max(ScoreReader.ReadScore()["easyScore"], Math.Max(ScoreReader.ReadScore()["mediumScore"], ScoreReader.ReadScore()["hardScore"]));

            //Set game speed and start the timer
            gw.gameTimer.Interval = 1000 / Difficulty.GameSpeed;
            gw.gameTimer.Tick += gw.UpdateScreen;
            gw.gameTimer.Start();

            StartGame(gw);
        }
        public void StartGame(GameWindow gw)
        {
            new Settings();
            gw.snake.Clear(); // deletes old snake
            gw.lblGameOver.Visible = false;
            gw.btnStartGame.Enabled = false;
            gw.btnSettings.Enabled = false;
            gw.radioBtnGroupBox.Enabled = false;

            // creates new snake
            Square head = new Square();
            Square piece = new Square();
            piece.xCoord = head.xCoord = 10;
            piece.yCoord = head.yCoord = 5;
            gw.snake.Add(head);
            gw.snake.Add(piece);

            GenerateFood(gw);

            gw.lblScore.Text = "Score: " + Settings.Score;
            gw.lblMultiplier.Text = string.Format("Multiplier: x{0:0.00}", Settings.Multiplier);
        }
        public void UpdateScreen(object sender, EventArgs e, GameWindow gw)
        {
            if (Settings.GameOver == true) // checks if the game has ended and starts a new one if enter is pressed
            {
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame(gw);
                }
            }
            else
            {
                // makes sure it doesn't do impossible moves
                if ((Input.KeyPressed(Keys.Right) || Input.KeyPressed(Keys.D)) && Settings.Direction != Direction.Left)
                    Settings.Direction = Direction.Right;

                else if ((Input.KeyPressed(Keys.Left) || Input.KeyPressed(Keys.A)) && Settings.Direction != Direction.Right)
                    Settings.Direction = Direction.Left;

                else if ((Input.KeyPressed(Keys.Up) || Input.KeyPressed(Keys.W)) && Settings.Direction != Direction.Down)
                    Settings.Direction = Direction.Up;

                else if ((Input.KeyPressed(Keys.Down) || Input.KeyPressed(Keys.S)) && Settings.Direction != Direction.Up)
                    Settings.Direction = Direction.Down;

                SnakeEvents se = new SnakeEvents();
                se.MoveSnake(gw);
            }

            gw.pbCanvas.Invalidate(); //Updates the screen
        }
        public void GenerateFood(GameWindow gw)
        {
            gw.multiplierStopwatch.Restart();
            ushort maxXPosition = (ushort)(gw.pbCanvas.Size.Width / Settings.Width);
            ushort maxYPosition = (ushort)(gw.pbCanvas.Size.Height / Settings.Height);
            bool collides = false;

            Random getPos = new Random();
            gw.food = new Square();

            while (true) // makes sure the food doesn't spawn on top of the snake
            {
                collides = false;
                gw.food.xCoord = getPos.Next(0, maxXPosition);
                gw.food.yCoord = getPos.Next(0, maxYPosition);

                foreach (var piece in gw.snake)
                {
                    if (piece.xCoord == gw.food.xCoord || piece.yCoord == gw.food.yCoord)
                        collides = true;
                }

                if (!collides)
                    break;
            }
        }
        public void CheckHighScore(GameWindow gw)
        {
            int currentScore = Settings.Score;

            // check if the current score is a high score and if it is, write it down and update the label
            if (gw.radioBtnEasy.Checked == true)
            {
                if (currentScore > ScoreReader.ReadScore()["easyScore"])
                {
                    ScoreWriter.WriteEasyScore(currentScore);
                    gw.lblEasyHighScore.Text = "Easy: " + currentScore;
                }
            }
            else if (gw.radioBtnMedium.Checked == true)
            {
                if (currentScore > ScoreReader.ReadScore()["mediumScore"])
                {
                    ScoreWriter.WriteMediumScore(currentScore);
                    gw.lblMediumHighScore.Text = "Medium: " + currentScore;
                }
            }
            else if (gw.radioBtnHard.Checked == true)
            {
                if (currentScore > ScoreReader.ReadScore()["hardScore"])
                {
                    ScoreWriter.WriteHardScore(currentScore);
                    gw.lblHardHighScore.Text = "Hard: " + currentScore;
                }
            }
            // update the highest score label in case the current high score is the biggest of them all
            gw.lblHighestScore.Text = "Highest Score: " + Math.Max(ScoreReader.ReadScore()["easyScore"], Math.Max(ScoreReader.ReadScore()["mediumScore"], ScoreReader.ReadScore()["hardScore"]));
        }
    }
}
