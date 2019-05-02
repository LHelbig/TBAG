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
        //following block has been phased out
       /* public AdventureOne a1 = new AdventureOne();
        public AdventureTwo a2 = new AdventureTwo();
        public AdventureThree a3 = new AdventureThree();*/

            //setup for potential save feature
       // private AdventureInformation adventure = AdventureInformation.Instance();
        public LoadGame()
        {
           // adventure.Load();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* adventure.setCurrent("one", false);
            adventure.setCurrent("two", false);
            adventure.setCurrent("three", false);
            adventure.Save();*/
            this.Hide();
            MainMenu mm = new TBAG.MainMenu();
            mm.ShowDialog();
            this.Close();
        }

        private void loadAdventureOne(object sender, EventArgs e)
        {
            GameScreen gs = new GameScreen();
            /*adventure.setCurrent("one",true);
            adventure.Save();*/
            this.Hide();
            gs.ShowDialog();

            this.Close();
        }

        private void loadAdventureTwo(object sender, EventArgs e)
        {
            GameScreen gs = new GameScreen();
           /* adventure.setCurrent("two", true);
            adventure.Save();*/
            this.Hide();
            gs.ShowDialog();

            this.Close();
        }

        private void loadAdventureThree(object sender, EventArgs e)
        {
            GameScreen gs = new GameScreen();
            /*adventure.setCurrent("three", true);
            adventure.Save();*/
            this.Hide();
            
            gs.ShowDialog();
            this.Close();
        }
    }
}
