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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            frmCharacterCreation charCreation = new frmCharacterCreation();
            charCreation.Show();           
        }

        private void btnMainQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {

        }
    }
}
