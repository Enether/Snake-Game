using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    class SettingEvents
    {
        public void SettingsForm_Closed(GameWindow gw)
        {
            // checks if any settings have been changed
            CheckBackgroundColor(gw);
            CheckSoundtrackStop(gw);
            gw.btnSettings.Enabled = true;
            gw.btnStartGame.Focus();
        }
        public void SettingsButton_Clicked(GameWindow gw)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();

            gw.btnSettings.Enabled = false;
            settingsForm.FormClosed += new FormClosedEventHandler(gw.SettingsForm_FormClosed);
        }
        public void CheckBackgroundColor(GameWindow gw)
        {
            // checks the background color and changes it along with the game over text if need be
            switch (Settings.BackgroundColor)
            {
                case BackgroundColor.LightBlue:
                    gw.pbCanvas.BackColor = Color.LightBlue;
                    gw.lblGameOver.BackColor = Color.LightBlue;
                    gw.lblGameOver.ForeColor = Color.Black;
                    gw.pbCanvas.Paint += new PaintEventHandler(gw.pbCanvas_PaintLightBlue);
                    break;
                case BackgroundColor.Black:
                    gw.pbCanvas.BackColor = Color.Black;
                    gw.lblGameOver.BackColor = Color.Black;
                    gw.lblGameOver.ForeColor = Color.White;
                    gw.pbCanvas.Paint += new PaintEventHandler(gw.pbCanvas_PaintBlack);
                    break;
                case BackgroundColor.Indigo:
                    gw.pbCanvas.BackColor = Color.Indigo;
                    gw.lblGameOver.BackColor = Color.Indigo;
                    gw.lblGameOver.ForeColor = Color.White;
                    gw.pbCanvas.Paint += new PaintEventHandler(gw.pbCanvas_PaintIndigo);
                    break;
                case BackgroundColor.DarkKhaki:
                    gw.pbCanvas.BackColor = Color.DarkKhaki;
                    gw.lblGameOver.BackColor = Color.DarkKhaki;
                    gw.lblGameOver.ForeColor = Color.Black;
                    gw.pbCanvas.Paint += new PaintEventHandler(gw.pbCanvas_PaintLightBlue);
                    break;
            }
        }
        public void CheckSoundtrackStop(GameWindow gw)
        {
            if (Settings.StopSoundtrack)
                gw.backgroundSoundtrack.Stop();
            else if (Settings.StartSoundtrack)
                gw.backgroundSoundtrack.PlayLooping();
        }
        public void EasyRadioButtonChecked(GameWindow gw)
        {
            Difficulty.Points = 75;
            Difficulty.GameSpeed = 12;
            gw.gameTimer.Interval = 1000 / Difficulty.GameSpeed;
        }
        public void MediumRadioButtonChecked(GameWindow gw)
        {
            Difficulty.Points = 100;
            Difficulty.GameSpeed = 16;
            gw.gameTimer.Interval = 1000 / Difficulty.GameSpeed;
        }
        public void HardRadioButtonChecked(GameWindow gw)
        {
            Difficulty.Points = 175;
            Difficulty.GameSpeed = 24;
            gw.gameTimer.Interval = 1000 / Difficulty.GameSpeed;
        }
    }
}
