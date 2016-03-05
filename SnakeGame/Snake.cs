using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class GameWindow : Form
    {
        SnakeEvents snakeEvents = new SnakeEvents();
        SettingEvents settingEvents = new SettingEvents();
        GameEvents gameEvents = new GameEvents();
        PaintEvents paintEvents = new PaintEvents();
        public List<Square> snake = new List<Square>();
        public Square food = new Square();
        public const double MULTIPLIER_INCREMENT = 0.15;
        ScoreWriter sw = new ScoreWriter();
        public Stopwatch multiplierStopwatch = new Stopwatch();
        public SoundPlayer backgroundSoundtrack = new SoundPlayer(@"..\..\Sounds\bgMusic.wav");
           
        // TODO: Fix StopWatch bug 
        public GameWindow()
        {
            InitializeComponent();
            //Start the game
            gameEvents.InitializeGame(this);           
        }
        public void UpdateScreen(object sender, EventArgs e)
        {
            gameEvents.UpdateScreen(sender, e, this);
        }
        public void pbCanvas_PaintLightBlue(object sender, PaintEventArgs e)
        {
            paintEvents.PaintLightBlue(e, this);
        }
        public void pbCanvas_PaintBlack(object sender, PaintEventArgs e)
        {
            paintEvents.PaintBlack(e, this);
        }
        public void pbCanvas_PaintIndigo(object sender, PaintEventArgs e)
        {
            paintEvents.PaintIndigo(e, this);
        }
        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            gameEvents.StartGame(this);
        }
        private void GameWindow_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        private void radioBtnEasy_CheckedChanged(object sender, EventArgs e)
        {
            settingEvents.EasyRadioButtonChecked(this);
        }

        private void radioBtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            settingEvents.MediumRadioButtonChecked(this);
        }

        private void radioBtnHard_CheckedChanged(object sender, EventArgs e)
        {
            settingEvents.HardRadioButtonChecked(this);
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingEvents.SettingsButton_Clicked(this);
        }
        public void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            settingEvents.SettingsForm_Closed(this);
        }
    }
}
