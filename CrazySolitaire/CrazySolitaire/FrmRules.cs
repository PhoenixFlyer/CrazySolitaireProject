using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FrmRules : Form
    {
        public FrmRules()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRules_Load(object sender, EventArgs e)
        {
            using (var ms = new MemoryStream(Properties.Resources.HowToPlay))
            {
                txtRules.LoadFile(ms, RichTextBoxStreamType.RichText);
            }

        }
    }
}
