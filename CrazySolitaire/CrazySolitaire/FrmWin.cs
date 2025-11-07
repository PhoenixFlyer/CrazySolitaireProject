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
    public partial class FrmWin : Form
    {
        public FrmWin()
        {
            InitializeComponent();
        }

        private void frmWin_Load(object sender, EventArgs e)
        {

        }

        private void btnWinNewGame_Click(object sender, EventArgs e)
        {
            FrmGame.Instance.btnNewGame_Click(sender, e);
            FrmGame.frmWin.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmGame.Instance.Close();
        }
    }
}
