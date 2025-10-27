using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazySolitaire
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();

        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            Game.SettingsForm = this;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void chkAutoplay_CheckedChanged(object sender, EventArgs e)
        {
            FrmGame.autoplay = chkAutoplay.Checked;
        }

        private void btnRulse_Click(object sender, EventArgs e)
        {
            FrmRules rules = new();
            rules.Show();
        }

        private void lblMusic_Click(object sender, EventArgs e)
        {

        }

        private void MusicChk_CheckedChanged(object sender, EventArgs e)
        {
            if (MusicChk.Checked) Game.MySoundPlayer.Play();
            else Game.MySoundPlayer.Stop();
        }
    }
}
