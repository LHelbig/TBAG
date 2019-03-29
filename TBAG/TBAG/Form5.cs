using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBAG
{
    public partial class LoadGame : Form
    {
        public LoadGame()
        {
            InitializeComponent();
        }

        public void loadGameScreen(object sender, EventArgs e)
        {
            GameScreen gs = new GameScreen();
            this.Hide();
            gs.ShowDialog();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new TBAG.MainMenu();
            mm.ShowDialog();
            this.Close();
        }
    }
}
