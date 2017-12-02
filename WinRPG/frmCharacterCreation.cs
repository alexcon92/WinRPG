using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRPG
{
    public partial class frmCharacterCreation : Form
    {
        public frmCharacterCreation()
        {
            InitializeComponent();
        }

        private void btnCCStartGame_Click(object sender, EventArgs e)
        {
            frmGame game = new frmGame();
            game.Show();
            Dispose();
        }
    }
}
