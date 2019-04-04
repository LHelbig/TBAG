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
        AdventureOne a1 = new AdventureOne();
        AdventureTwo a2 = new AdventureTwo();
        AdventureThree a3 = new AdventureThree();
        public LoadGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new TBAG.MainMenu();
            mm.ShowDialog();
            this.Close();
        }

        private void loadAdventureOne(object sender, EventArgs e)
        {
            GameScreen gs = new GameScreen();
            a1.setCurrent(true);
            this.Hide();
            gs.ShowDialog();

            this.Close();
        }

        private void loadAdventureTwo(object sender, EventArgs e)
        {
            GameScreen gs = new GameScreen();
            a2.setCurrent(true);
            this.Hide();
            gs.ShowDialog();

            this.Close();
        }

        private void loadAdventureThree(object sender, EventArgs e)
        {
            GameScreen gs = new GameScreen();
            a3.setCurrent(true);
            this.Hide();
            
            gs.ShowDialog();
            this.Close();
        }
    }
}
