using System;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            if (Settings.StopSoundtrack) // makes sure the checkbox is checked if it has been checked ealier
                checkboxStopSoundtrack.Checked = true;
            this.Focus();
        }

        private void btnBlackBG_Click(object sender, EventArgs e)
        {
            Settings.BackgroundColor = BackgroundColor.Black;
            this.Focus();
        }
        private void btnLightBlueBG_Click(object sender, EventArgs e)
        {
            Settings.BackgroundColor = BackgroundColor.LightBlue;
            this.Focus();
        }

        private void btnIndigoBG_Click(object sender, EventArgs e)
        {
            Settings.BackgroundColor = BackgroundColor.Indigo;
            this.Focus();
        }

        private void btnDarkKhakiBG_Click(object sender, EventArgs e)
        {
            Settings.BackgroundColor = BackgroundColor.DarkKhaki;
            this.Focus();
        }

        private void checkboxStopSoundtrack_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxStopSoundtrack.Checked == true)
            {
                Settings.StopSoundtrack = true;
                Settings.StartSoundtrack = false;
            }
            else
            {
                // Starts the soundtrack if user unchecks the checkbox
                Settings.StopSoundtrack = false;
                Settings.StartSoundtrack = true;
            }
        }
    }
}
