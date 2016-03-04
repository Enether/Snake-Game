using System;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
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
    }
}
